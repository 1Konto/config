﻿using System;
using System.Net;

namespace Config.Net.Tests.Virtual
{
   public interface ITestCredential
   {
      [Option(Alias = "Azure.KeyVault.Uri")]
      Uri AzureKeyVaultUri { get; }

      [Option(Alias = "Azure.KeyVault.Creds")]
      NetworkCredential AzureKeyVaultCredentials { get; }
   }
}
