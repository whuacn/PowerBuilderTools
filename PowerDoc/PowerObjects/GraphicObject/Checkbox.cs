// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Checkbox : HardwiredObject {
		static Checkbox instance;

		static Checkbox() {
			instance = new Checkbox();
		}

		static public void Init() {
		}

		public static Checkbox Instance {
			get { return instance; }
		}

		protected Checkbox() : base(PowerObject.PowerObjectParent, "Checkbox", DragObject.Instance) {
		}
	}
}
