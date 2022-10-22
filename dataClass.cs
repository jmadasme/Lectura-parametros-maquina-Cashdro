using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashdro
{
    public class Device
    {
        public string deviceName { get; set; }
        public object deviceType { get; set; }
        public object deviceState { get; set; }
        public string portName { get; set; }
        public int portProtocol { get; set; }
        public object deviceId { get; set; }
        public List<object> portMessagesInfo { get; set; }
        public List<object> deviceMessagesInfo { get; set; }
        public bool deviceWithError { get; set; }
        public string deviceModel { get; set; }
        public string protocolName { get; set; }
        public string deviceImage { get; set; }
        public int? portState { get; set; }
        public string ip { get; set; }
        public bool? tooManyChanges { get; set; }
    }

    public class Data
    {
        public bool WithError { get; set; }
        public List<Device> Devices { get; set; }
    }

    public class RootObjectDevice
    {
        public int code { get; set; }
        public Data data { get; set; }
    }


    public class Datum
    {
        public string CurrencyId { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Destination { get; set; }
        public string MinLevel { get; set; }
        public string MaxLevel { get; set; }
        public string MaxLevelTemp { get; set; }
        public string DepositLevel { get; set; }
        public string DepositLevelTemp { get; set; }
        public string MaxPiecesExchange { get; set; }
        public string MaxPiecesChange { get; set; }
        public string MaxPiecesCancel { get; set; }
        public string IsChargeable { get; set; }
        public string State { get; set; }
        public string Image { get; set; }
        public object LevelRecycler { get; set; }
        public object LevelCasete { get; set; }
    }

    public class RootObjectDatum
    {
        public int code { get; set; }
        public List<Datum> data { get; set; }
    }


}
