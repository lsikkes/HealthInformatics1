using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizer.Models
{
    [Obsolete]
    public class VRModel
    {
        #region Members

        private int _x;
        private int _y;

        #endregion Members

        #region Methods

        public VRModel()
        {
            _x = 0;
            _y = 0;
        }

        #endregion Methods

        #region Properties

        /// <summary>
        /// The artist name.
        /// </summary>
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }

        public int y
        {
            get { return _y; }
            set { _y = value; }
        }

        #endregion Properties
    }
}