using System.Collections.Generic;
using Game.Control.PersonSystem;

namespace Game.Scripts
{
    public class PersonCreater : UnityEngine.MonoBehaviour
    {
        public List<BaseCharacterInfo> CharacterInfos=new List<BaseCharacterInfo>();
        public bool createOnStart = true;

        private AbstractPerson sss;
        private void Awake()
        {
            if (createOnStart)
            {
                foreach (var VARIABLE in CharacterInfos)
                {
                    if (VARIABLE is PlayerInfo)
                        new Player(VARIABLE);
                    else
                    {
                        sss= new TestPerson(VARIABLE);
                    }                    
                }
            }

        }


        private void Update()
        {
           // sss.obj.GetComponent<Actor>().Patrol();
        }
    }
}