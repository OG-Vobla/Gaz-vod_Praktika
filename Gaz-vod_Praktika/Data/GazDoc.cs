using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Gaz_vod_Praktika.Data
{
    public class GazDoc
    {
        private string designerLogin;
        private string pipelineDiameterTE;
        private string lengthObjectTE;
        private string pipelineDiameter;
        private string lengthObject;
        private string sum;
        private string time;

        public GazDoc(string pipelineDiameterTE, string lengthObjectTE, string pipelineDiameter, string lengthObject, string sum, string time, string designerLogin)
        {
            PipelineDiameterTE = pipelineDiameterTE;
            LengthObjectTE = lengthObjectTE;
            PipelineDiameter = pipelineDiameter;
            LengthObject = lengthObject;
            Sum = sum;
            Time = time;
            DesignerLogin = designerLogin;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string DesignerLogin { get { return designerLogin; } set { designerLogin = value; } }
        public string PipelineDiameterTE { get { return pipelineDiameterTE; } set { pipelineDiameterTE = value; } }
        public string LengthObjectTE { get { return lengthObjectTE; } set { lengthObjectTE = value; } }
        public string PipelineDiameter { get { return pipelineDiameter; } set { pipelineDiameter = value; } }
        public string LengthObject { get { return lengthObject; } set { lengthObject = value; } }
        public string Sum { get { return sum; } set { sum = value; } }
        public string Time { get { return time; } set { time = value; } }
    }
}
