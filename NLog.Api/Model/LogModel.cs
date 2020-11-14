using Newtonsoft.Json;

namespace NLog.Api.Model
{
    public class LogModel
    {
        public int Codigo { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

    }
}
