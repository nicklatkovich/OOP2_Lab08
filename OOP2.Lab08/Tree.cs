using System.Collections.Generic;

namespace OOP2.Lab08 {
    public class Tree<T> {

        public T Data;
        private List<Tree<T>> _children = new List<Tree<T>>( );
        private Tree<T> _parent = null;

        public Tree<T>[ ] Children {
            get {
                return this._children.ToArray( );
            }
        }
        public Tree<T> Parent {
            get {
                return this._parent;
            }
            set {
                if (this._parent != null) {
                    this._parent._children.Remove(this);
                }
                this._parent = value;
                if (value != null) {
                    value._children.Add(this);
                }
            }
        }

        public Tree(T data, Tree<T> parent) {
            this.Data = data;
            this.Parent = parent;
        }

        public Tree<T> Add(T data) {
            return new Tree<T>(data, this);
        }

    }
}
