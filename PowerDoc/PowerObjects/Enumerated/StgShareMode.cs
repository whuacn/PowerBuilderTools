// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class StgShareMode : HardwiredObject {
		static StgShareMode instance;

		static StgShareMode() {
			instance = new StgShareMode();
		}

		static public void Init() {
		}

		public static StgShareMode Instance {
			get { return instance; }
		}

		protected StgShareMode() : base(PowerObject.PowerObjectParent, "StgShareMode", EnumeratedType.Instance) {
		}
	}
}