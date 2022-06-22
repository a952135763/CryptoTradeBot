﻿using FractionalCryptoBot.Configuration;
using FractionalCryptoBot.Enumerations;
using System;

namespace Tests.Authentication_Tests
{
  public class AuthenticationStub
  {
    public IAuthentication Authentication { get; set; } = new ExchangeAuthentication();
    private string _path = AuthenticationConfig.GetAuthenticationFilePath();
    
    public AuthenticationStub WithDefault()
    {
      _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "FCB_Test.json";
      return this;
    }

    public AuthenticationStub Build()
    {
      AuthenticationConfig.Initialise(_path);
      Authentication = AuthenticationConfig.GetAuthentication(Marketplaces.BINANCE) ?? new ExchangeAuthentication();
      return this;
    }
  }
}
