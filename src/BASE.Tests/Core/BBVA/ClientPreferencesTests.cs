﻿using BASE.Core.BBVA;
using BASE.Cross;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BASE.Tests.Core.BBVA
{
    [TestClass]
    public class ClientPreferencesTests
    {
        [TestMethod]
        public void Should_be_return_a_valid_client_preferences()
        {
            const string token = "YXBwLmJidmEucGxhaW46VkFLUXQwNHRzb2FQb0ZVQGw5Q09KODQlV3ZCV09BVGM0dGVLekZneVo5endAakdDdnhsRVZBaFdBR2pKVFlTWQ==";
            var client = new BBVAuthClient(token);
            var result = client.GetCredentials().Result;

            Assert.IsNotNull(result);
        }
    }

}