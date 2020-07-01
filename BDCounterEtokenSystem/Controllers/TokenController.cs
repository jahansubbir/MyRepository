using System.Collections.Generic;
using BDCounterEtokenSystem.Models;
using BDCounterEtokenSystem.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BDCounterEtokenSystem.Controllers
{
    public class TokenController:Controller
    {
        private readonly ITokenRepository _tokenRepository;
        private readonly ICounterRepository _counterRepository;
        private readonly ITokenTypeRepository _tokenTypeRepository;


        public TokenController(ITokenRepository tokenRepository,ICounterRepository counterRepository,ITokenTypeRepository tokenTypeRepository)
        {
            _tokenRepository = tokenRepository;
            _counterRepository = counterRepository;
            _tokenTypeRepository = tokenTypeRepository;
            //    _tokenDetailsRepository = tokenDetailsRepository;
        }

        

        public IEnumerable<Token> GetTokens()
        {
            return _tokenRepository.GetTokens();
        }

        public Token GetToken(int id)
        {
            return _tokenRepository.GetToken(id);
        }

        public Token Post(Token token, List<TokenDetail> details)
        {
            var counter = _counterRepository.GetCounter(token.Id);
            return token;
        }
    }
}
