using System;
using HighFive.Data;
using ReadyGamerOne.Data;
using ReadyGamerOne.Rougelike.Item;
using UnityEngine.Assertions;

namespace HighFive.Model.ItemSystem
{
    public interface IHighFiveItem :
        IItemInfo,
        IUseCsvData
    {
        
    }
    
    public class HighFiveItem:
        AbstractItemInfo,
        IHighFiveItem
    {
        #region IUseCsvData

        public CsvMgr CsvData => _itemData;
        public Type DataType => typeof(ItemData);
        public void LoadData(CsvMgr data)
        {
            _itemData=data as ItemData;
            Assert.IsNotNull(_itemData);
        }        

        #endregion

        #region IItemInfo

        public override string ID => _itemData.ID;
        public override string ItemName => _itemData.itemName;
        public override string UiText => _itemData.uitext;
        public override int Count
        {
            get { return _count;}
            set { _count = value; }
        }
        
        public override string SpriteName => _itemData.spriteName;
        public override int MaxSlotCount => _itemData.maxSlotCount;
        public override string ItemPrefabName => _itemData.prefabName;
        public override string Statement => _itemData.statement;

        #endregion
        
        /// <summary>
        /// 这个函数会反射调用
        /// </summary>
        /// <param name="itemData"></param>
        /// <param name="count"></param>
        public virtual void Refresh(ItemData itemData, int count = 1)
        {
            _count = count;
            LoadData(itemData);
        }
        
        #region Fields

        protected int _count;

        protected ItemData _itemData;
        
        #endregion
        
    }
}