// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Line : HardwiredObject {
		static Line instance;

		static Line() {
			instance = new Line();
		}

		static public void Init() {
		}

		public static Line Instance {
			get { return instance; }
		}

		protected Line() : base(PowerObject.PowerObjectParent, "Line", DrawObject.Instance) {
		}
	}
}
