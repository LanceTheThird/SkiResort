using Data.Entities.Card;
using System.Collections.Generic;
using System.Linq;
using Data.Repository.Abstract;
using Turnstile.Models;
using Turnstile.Services.Abstract;
using System;
using Turnstile.Middleware;
using Microsoft.AspNetCore.Http;

namespace Turnstile.Services.Concrete
{
    public class TurnstileService : ITurnstileService
    {
        public TurnstileService(IResortRepository<Card> cardRepository, IResortRepository<Data.Entities.Turnstiles.Turnstile> turnstileRepository)
        {
            _cardRepository = cardRepository;
            _turnstileRepository = turnstileRepository;
        }

        private IResortRepository<Card> _cardRepository;
        private IResortRepository<Data.Entities.Turnstiles.Turnstile> _turnstileRepository;
        public TurnstileEnterModel Enter(TurnstileRequest request)
        {
            //throw new HttpStatusCodeException(StatusCodes.Status400BadRequest, @"You sent bad stuff");
            var card = _cardRepository.GetAll()
                .SingleOrDefault(x => x.Id == request.CardId);
            var turnstile = _turnstileRepository.GetAll()
                .SingleOrDefault(x => x.Id == request.TurnstileId);

            foreach (var passTurn in turnstile.PassTurnstiles)
            {
                if (passTurn.Pass == card.Pass && card.NextPassingDate < DateTime.Now)
                {
                    OnEnterCardUpdate(card, turnstile);
                    return new TurnstileEnterModel();
                }
                else return new TurnstileEnterModel("Cant Enter yet");
            }
            return new TurnstileEnterModel("No Access");
        }

        private void OnEnterCardUpdate(Card card, Data.Entities.Turnstiles.Turnstile turnstile)
        {
            card.LastPassedGate = turnstile;
            card.LastPassedDate = DateTime.Now;
            card.NextPassingDate = DateTime.Now.AddMinutes(turnstile.TimeDelayToPassAgain);
            _cardRepository.Update(card);
        }
    }
}
