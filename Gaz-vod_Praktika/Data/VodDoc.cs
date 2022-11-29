using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Gaz_vod_Praktika.Data
{
    public class VodDoc
    {
        private string designerLogin;
        private string pipelineDiameter;
        private string lengthObject;
        private string efficiency;
        private string countAndEfficiency;
        private string sum;
        private string time;

        public VodDoc(string pipelineDiameter, string lengthObject, string efficiency, string countAndEfficiency, string sum, string time, string designerLogin)
        {
            PipelineDiameter = pipelineDiameter;
            LengthObject = lengthObject;
            Efficiency = efficiency;
            CountAndEfficiency = countAndEfficiency;
            Sum = sum;
            Time = time;
            DesignerLogin = designerLogin;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string DesignerLogin { get { return designerLogin; } set { designerLogin = value; } }
        public string PipelineDiameter { get { return pipelineDiameter; } set { pipelineDiameter = value; } }
        public string LengthObject { get { return lengthObject; } set { lengthObject = value; } }
        public string Efficiency { get { return efficiency; } set { efficiency = value; } }
        public string CountAndEfficiency { get { return countAndEfficiency; } set { countAndEfficiency = value; } }
        public string Sum { get { return sum; } set { sum = value; } }
        public string Time { get { return time; } set { time = value; } }
    }
}
