using IdentityModel.Client;
using ImageGallery.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace ImageGallery.Client.PostConfigurationOptions
{
    public class OpenIdConnectOptionsPostConfigureOptions
        : IPostConfigureOptions<OpenIdConnectOptions>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OpenIdConnectOptionsPostConfigureOptions(
            IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ??
                throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public void PostConfigure(string name, OpenIdConnectOptions options)
        {
            options.Events = new OpenIdConnectEvents()
            {
                OnTicketReceived = async ticketReceivedContext =>
                {
                    var subject = ticketReceivedContext.Principal.Claims
                        .FirstOrDefault(c => c.Type == "sub").Value;

                    var apiClient = _httpClientFactory.CreateClient("BasicAPIClient");

                    var request = new HttpRequestMessage(
                        HttpMethod.Get,
                        $"/api/applicationuserprofiles/{subject}");
                    request.SetBearerToken(
                        ticketReceivedContext.Properties.GetTokenValue("access_token"));

                    var response = await apiClient.SendAsync(
                        request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

                    response.EnsureSuccessStatusCode();

                    var applicationUserProfile = new ApplicationUserProfile();
                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        applicationUserProfile =
                            await JsonSerializer
                                .DeserializeAsync<ApplicationUserProfile>(responseStream);
                    }

                    var newClaimsIdentity = new ClaimsIdentity();
                    newClaimsIdentity.AddClaim(
                        new Claim("subscriptionlevel", applicationUserProfile.SubscriptionLevel));

                    // add this additional identity
                    ticketReceivedContext.Principal.AddIdentity(newClaimsIdentity);

                }
            };
        }
    }
}
