// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class RegistryValueType : HardwiredObject {
		static RegistryValueType instance;

		static RegistryValueType() {
			instance = new RegistryValueType();
		}

		static public void Init() {
		}

		public static RegistryValueType Instance {
			get { return instance; }
		}

		protected RegistryValueType() : base(PowerObject.PowerObjectParent, "RegistryValueType", EnumeratedType.Instance) {
		}
	}
}
