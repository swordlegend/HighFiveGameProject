using System;
using HighFive.Data;

namespace HighFive.Model.ItemSystem
{
    public static class ItemDataExtension
    {
        public static T CreateItem<T>(this ItemData data,int count)
            where T : HighFiveItem
        {
            var typeName = "HighFive.Model.ItemSystem." + data.itemName;
            
            var type = Type.GetType(typeName);

            if(null==type)
                throw new Exception("物品信息类Type为空："+typeName);
            
            var itemInfoObj = Activator.CreateInstance(type);
            
            var method = type.GetMethod("Refresh");

            if (null == method)
                throw new Exception("方法为空");
            
            method.Invoke(itemInfoObj,new object[]{data,count});

            var aif = itemInfoObj as T;

            if (aif == null)
                throw new Exception("转化失败");

            return aif;

        }
    }
}