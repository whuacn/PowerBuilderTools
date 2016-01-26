// Copyright (C) 2007  Jakub Linhart
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Diagnostics;

namespace PowerDoc {
	public class Argument : VariableBase {
		public enum PassingType { Value, Ref, Readonly };

		private PassingType passingType;

		public Argument(ScriptBase parent, string name, string type) : base(parent, name, type) {
			this.passingType = PassingType.Value;
			parent.AddArgument(this);

			this.documentation = new ArgumentDoc(this);
		}

		public Argument(ScriptBase parent, string name, string type, PassingType pass) : base(parent, name, type) {
			this.passingType = pass;
			parent.AddArgument(this);

			this.documentation = new ArgumentDoc(this);
		}

		public Argument(ScriptBase parent, string name, string type, PassingType pass, bool is_array) : base(parent, name, type, is_array) {
			this.passingType = pass;
			parent.AddArgument(this);

			this.documentation = new ArgumentDoc(this);
		}

		public PassingType ArgPassingType {
			get { return passingType; }
		}

		public new ArgumentDoc Documentation {
			get { return ( ArgumentDoc ) this.documentation; }
		}
	}
}