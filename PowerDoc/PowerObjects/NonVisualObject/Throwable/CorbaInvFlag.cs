// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class CorbaInvFlag : HardwiredObject {
		static CorbaInvFlag instance;

		static CorbaInvFlag() {
			instance = new CorbaInvFlag();
		}

		static public void Init() {
		}

		public static CorbaInvFlag Instance {
			get { return instance; }
		}

		protected CorbaInvFlag() : base(PowerObject.PowerObjectParent, "CorbaInvFlag", CorbaSystemException.Instance) {
		}
	}
}