using System;
using System.IO;
using System.Net;
using System.Text;

namespace WinFormApp.REST.Client {
    // enum vars for httpVerb
    public enum httpVerb {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClient {
        // Class properties
        public string endPoint {
            get; set;
        }
        public httpVerb httpMethod {
            get; set;
        }

        // Class constructor
        public RestClient() {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        // makeRequest method 
        public string makeRequest() {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                if (response.StatusCode != HttpStatusCode.OK) {
                    throw new ApplicationException("Error code: " + response.StatusCode);
                }
                // Process the response strream
                using (Stream responseStream = response.GetResponseStream()) {
                
                }
            }


            return strResponseValue;
        }

    }

}
