using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace WalletConnectUnity.Core.Networking
{
    public struct UrlQueryParams
    {
        // mandatory
        public string Page { get; set; }

        // mandatory
        public string Entries { get; set; }

        public string Search { get; set; }

        public string Include { get; set; }

        public string Exclude { get; set; }

        public string Platform { get; set; }
    }
    [System.Serializable]
    public class GetWalletsResponse
    {
        public int count;
        public List<Wallet> data;
        public int Count { get { return count; } set { count = value; } }
        public Wallet[] Data { 
            get {
                return data.ToArray();
            } 
            set {
                data = value.ToList();
            } 
        }

    }
    [System.Serializable]
    public class Wallet
    {
        public string id;
        public string Id { get => id; set {id = value;} }

        public string name;
        public string Name { get => name; set{name = value;} }
        
        public string homepage;
        public string Homepage { get => homepage; set{homepage=value;} }

        public string image_id;
        public string ImageId { get => image_id; set{image_id = value;} }

        public int order;
        public int Order { get => order; set{order = value;} }

        public string mobile_link;
        public string MobileLink { get => mobile_link; set{mobile_link = value;} }

        public string desktop_link;
        public string DesktopLink { get => desktop_link; set{desktop_link = value;} }

        public string webapp_link;
        public string WebappLink { get => webapp_link; set{webapp_link = value;} }

        public string app_store;
        public string AppStore { get => app_store; set{app_store = value;}}

        public string play_store;
        public string PlayStore { get => play_store; set{play_store = value;} }
    }
}