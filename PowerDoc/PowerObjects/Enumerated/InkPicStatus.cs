// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class InkPicStatus : HardwiredObject {
		static InkPicStatus instance;

		static InkPicStatus() {
			instance = new InkPicStatus();
		}

		static public void Init() {
		}

		public static InkPicStatus Instance {
			get { return instance; }
		}

		protected InkPicStatus() : base(PowerObject.PowerObjectParent, "InkPicStatus", EnumeratedType.Instance) {
		}
	}
}