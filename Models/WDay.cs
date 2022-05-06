namespace  DevExtremeAsp.Models {
    public class WDay {
        public int Code { get; set; }
        public string Name { get; set; }

        public WDay(int code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}