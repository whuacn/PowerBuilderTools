// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class SizeMode : HardwiredObject {
		static SizeMode instance;

		static SizeMode() {
			instance = new SizeMode();
		}

		static public void Init() {
		}

		public static SizeMode Instance {
			get { return instance; }
		}

		protected SizeMode() : base(PowerObject.PowerObjectParent, "SizeMode", EnumeratedType.Instance) {
		}
	}
}
