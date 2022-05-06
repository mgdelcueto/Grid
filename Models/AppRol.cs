namespace  DevExtremeAsp.Models {
    public class AppRol {
        public string Code { get; set; }
        public string Name { get; set; }

        public AppRol(string code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}