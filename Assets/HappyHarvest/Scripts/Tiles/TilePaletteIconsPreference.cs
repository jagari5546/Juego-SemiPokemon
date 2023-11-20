using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Tilemaps;

namespace UnityEngine.Tilemaps
{
    internal static class TilePaletteIconsPreference
    {
        public static string GetTexturePath(Type tileType)
        {
            
            //if (!tileType.IsSubclassOf(typeof(TileBase)))
                //return string.Empty;

            //if (!typeof(tileType).IsSubclassOf(typeof(TileBase)))
            {

            }
         

            return "UnityEngine/Tilemaps/Tile Icon";
        }

        internal static string GetTexturePath(System.Type type)
        {
            throw new System.NotImplementedException();
        }
    }
}