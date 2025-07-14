using System.Globalization;

namespace HRBS.Dto
{
    public class ResponseDto
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public ResponseDto(bool status, string message)
        {
            this.Status = status;
            this.Message = message;
        }
        public ResponseDto(bool status,string message,object data)
        {
            this.Status = status;
            this.Message = message;
            this.Data = data;
        }
    }
}
