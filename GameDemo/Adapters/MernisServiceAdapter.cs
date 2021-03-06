using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;
using MernisServiceReference;

namespace GameDemo.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
            (Convert.ToInt64(player.NationalityId),
                player.Name.ToUpper(),
                player.LastName.ToUpper(), 
                player.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
