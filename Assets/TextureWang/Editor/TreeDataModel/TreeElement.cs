using System;
using System.Collections.Generic;
using UnityEngine;


namespace UnityEditor.TreeViewExamples
{

    [Serializable]
    public class TreeElement
    {
        [SerializeField] int m_ID;
        [SerializeField] string m_Name;
        [SerializeField] int m_Depth;
        [NonSerialized] TreeElement m_Parent;
        [NonSerialized] List<TreeElement> m_Children;


        public virtual Texture2D GetIcon1()
        {
            return null;
        }

        public int depth
        {
            get { return m_Depth; }
            set { m_Depth = value; }
        }

        public TreeElement parent
        {
            get { return m_Parent; }
            set { m_Parent = value; }
        }

        public List<TreeElement> children
        {
            get { return m_Children; }
            set { m_Children = value; }
        }

        public void AddChild(TreeElement _add)
        {
            if(m_Children==null)
                m_Children=new List<TreeElement>();
            m_Children.Add(_add);

        }
    

    public bool hasChildren
		{
			get { return children != null && children.Count > 0; }
		}

		public string name
		{
			get { return m_Name; } set { m_Name = value; }
		}

		public int id
		{
			get { return m_ID; } set { m_ID = value; }
		}

		public TreeElement ()
		{
		}

		public TreeElement (string name, int depth, int id)
		{
			m_Name = name;
			m_ID = id;
			m_Depth = depth;
		}
	}

}


