// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class FontFamily : HardwiredObject {
		static FontFamily instance;

		static FontFamily() {
			instance = new FontFamily();
		}

		static public void Init() {
		}

		public static FontFamily Instance {
			get { return instance; }
		}

		protected FontFamily() : base(PowerObject.PowerObjectParent, "FontFamily", EnumeratedType.Instance) {
		}
	}
}
