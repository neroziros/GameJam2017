//uScript Generated Code - Build 1.0.3036
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/selector")]
public class selector_Component : uScriptCode
{
   #pragma warning disable 414
   public selector ExposedVariables = new selector( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject credit { get { return ExposedVariables.credit; } set { ExposedVariables.credit = value; } } 
   public System.Single axis { get { return ExposedVariables.axis; } set { ExposedVariables.axis = value; } } 
   public System.Single axis2 { get { return ExposedVariables.axis2; } set { ExposedVariables.axis2 = value; } } 
   public System.Int32 selectorVar { get { return ExposedVariables.selectorVar; } set { ExposedVariables.selectorVar = value; } } 
   public UnityEngine.GameObject play { get { return ExposedVariables.play; } set { ExposedVariables.play = value; } } 
   
   void Awake( )
   {
      #if !(UNITY_FLASH)
      useGUILayout = false;
      #endif
      ExposedVariables.Awake( );
      ExposedVariables.SetParent( this.gameObject );
      if ( "1.CMR" != uScript_MasterComponent.Version )
      {
         uScriptDebug.Log( "The generated code is not compatible with your current uScript Runtime " + uScript_MasterComponent.Version, uScriptDebug.Type.Error );
         ExposedVariables = null;
         UnityEngine.Debug.Break();
      }
   }
   void Start( )
   {
      ExposedVariables.Start( );
   }
   void OnEnable( )
   {
      ExposedVariables.OnEnable( );
   }
   void OnDisable( )
   {
      ExposedVariables.OnDisable( );
   }
   void Update( )
   {
      ExposedVariables.Update( );
   }
   void OnDestroy( )
   {
      ExposedVariables.OnDestroy( );
   }
   #if UNITY_EDITOR
      void OnDrawGizmos( )
      {
         {
            GameObject gameObject;
            gameObject = GameObject.Find( "selectPlay" ); 
            if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_variables.png");
         }
         {
            GameObject gameObject;
            gameObject = GameObject.Find( "selectCredits" ); 
            if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_variables.png");
         }
      }
   #endif
}
