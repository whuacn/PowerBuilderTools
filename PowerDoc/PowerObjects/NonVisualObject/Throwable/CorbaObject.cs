// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class CorbaObject : HardwiredObject {
		static CorbaObject instance;

		static CorbaObject() {
			instance = new CorbaObject();
		}

		static public void Init() {
		}

		public static CorbaObject Instance {
			get { return instance; }
		}

		protected CorbaObject() : base(PowerObject.PowerObjectParent, "CorbaObject", NonVisualObject.Instance) {
		}
	}
}