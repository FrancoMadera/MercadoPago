using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoPago.Client.Common;
using MercadoPago.Client.Payment;
using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Preference;

namespace MercadoPago
{
    public class Class1
    {
        // Cria o objeto de request da preferência
        var request = new PreferenceRequest
        {
            Items = new List<PreferenceItemRequest>
          {
              new PreferenceItemRequest
              {
                  Id = "item-ID-1234",
                  Title = "Meu produto",
                  CurrencyId = "BRL",
                  PictureUrl = "https://www.mercadopago.com/org-img/MP3/home/logomp3.gif",
                  Description = "Descrição do Item",
                  CategoryId = "art",
                  Quantity = 1,
                  UnitPrice = 75.76m
              }
          },
            Payer = new PayerRequest
            {
                Name = "João",
                Surname = "Silva",
                Email = "user@email.com",
                Phone = new PhoneRequest
                {
                    AreaCode = "11",
                    Number = "4444-4444"
                },
                Identification = new IdentificationRequest
                {
                    Type = "CPF",
                    Number = "19119119100"
                },
                Address = new AddressRequest
                {
                    StreetName = "Street",
                    StreetNumber = 123,
                    ZipCode = "06233200"
                }
            },
            BackUrls = new BackUrlsRequest
            {
                Success = "https://www.success.com",
                Failure = "http://www.failure.com",
                Pending = "http://www.pending.com"
            },
            AutoReturn = "approved",
            PaymentMethods = new PaymentMethodsRequest,
            excludedPaymentMethods = new List<PreferencePaymentMethodRequest>
            {
                ExcludedPaymentTypes = new ArrayList<>(),
            },

            NotificationUrl = "https://www.your-site.com/ipn",
            StatementDescriptor = "MEUNEGOCIO",
            ExternalReference = "Reference_1234",
            Expires = true,
            ExpirationDateFrom = DateTimeOffset.Parse("2016-02-01T12:00:00.000-04:00"),
            ExpirationDateTo = DateTimeOffset.Parse("2016-02-28T12:00:00.000-04:00")
        };

        // Cria a preferência usando o client
        var client = new PreferenceClient();
        Preference preference = await client.CreateAsync(request);


    }
}
    

