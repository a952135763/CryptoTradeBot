﻿using FractionalCryptoBot.Configuration;
using FractionalCryptoBot.Enumerations;

namespace Tests.Authentication_Tests
{
  public class AuthenticationStub
  {
    public readonly IAuthentication? Authentication;

    public AuthenticationStub()
    {
      AuthenticationConfig.Initialise(string.Empty);
      Authentication = AuthenticationConfig.GetAuthentication(Marketplaces.BINANCE);
    }
  }
}