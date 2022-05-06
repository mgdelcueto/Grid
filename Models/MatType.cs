namespace  DevExtremeAsp.Models {
    public class MatType {
        public string Code { get; set; }
        public string Name { get; set; }

        public MatType(string code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}