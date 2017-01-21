//uScript Generated Code - Build 1.0.3036
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class menuscript : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   UnityEngine.GameObject local_0_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_0_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_15_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_15_UnityEngine_GameObject_previous = null;
   System.Int32 local_19_System_Int32 = (int) 1;
   UnityEngine.GameObject local_30_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_30_UnityEngine_GameObject_previous = null;
   System.Int32 local_5_System_Int32 = (int) 1;
   UnityEngine.GameObject local_9_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_9_UnityEngine_GameObject_previous = null;
   System.String local_closed_System_String = "closed";
   System.Int32 local_cual_System_Int32 = (int) 0;
   System.String local_open_System_String = "open";
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AnimatorPlay logic_uScriptAct_AnimatorPlay_uScriptAct_AnimatorPlay_1 = new uScriptAct_AnimatorPlay( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorPlay_Target_1 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorPlay_Name_1 = "";
   System.Int32 logic_uScriptAct_AnimatorPlay_Layer_1 = (int) -1;
   System.Single logic_uScriptAct_AnimatorPlay_NormalizedTime_1 = (float) -1;
   bool logic_uScriptAct_AnimatorPlay_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_3 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_3 = (int) 0;
   System.Int32 logic_uScriptAct_SetInt_Target_3;
   bool logic_uScriptAct_SetInt_Out_3 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_4 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_4 = (int) 1;
   System.Int32 logic_uScriptCon_CompareInt_B_4 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_4 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_4 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_4 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_4 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_4 = true;
   bool logic_uScriptCon_CompareInt_LessThan_4 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_7 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_7 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_7 = (int) 1;
   bool logic_uScriptCon_CompareInt_GreaterThan_7 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_7 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_7 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_7 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_7 = true;
   bool logic_uScriptCon_CompareInt_LessThan_7 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_10 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_10 = (int) 1;
   System.Int32 logic_uScriptCon_CompareInt_B_10 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_10 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_10 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_10 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_10 = true;
   bool logic_uScriptCon_CompareInt_LessThan_10 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_12 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_12 = UnityEngine.KeyCode.DownArrow;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_12 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_12 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_12 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorPlay logic_uScriptAct_AnimatorPlay_uScriptAct_AnimatorPlay_13 = new uScriptAct_AnimatorPlay( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorPlay_Target_13 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorPlay_Name_13 = "";
   System.Int32 logic_uScriptAct_AnimatorPlay_Layer_13 = (int) -1;
   System.Single logic_uScriptAct_AnimatorPlay_NormalizedTime_13 = (float) -1;
   bool logic_uScriptAct_AnimatorPlay_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_17 = UnityEngine.KeyCode.Space;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_17 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_18 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_18 = (int) 1;
   System.Int32 logic_uScriptCon_CompareInt_B_18 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_18 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_18 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_18 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_18 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_18 = true;
   bool logic_uScriptCon_CompareInt_LessThan_18 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_20 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_20 = (int) 0;
   System.Int32 logic_uScriptAct_SetInt_Target_20;
   bool logic_uScriptAct_SetInt_Out_20 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_21 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_21 = (int) 1;
   System.Int32 logic_uScriptAct_SetInt_Target_21;
   bool logic_uScriptAct_SetInt_Out_21 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_24 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_24 = (int) 0;
   System.Int32 logic_uScriptAct_SetInt_Target_24;
   bool logic_uScriptAct_SetInt_Out_24 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_25 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_25 = UnityEngine.KeyCode.UpArrow;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_25 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_25 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_25 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_29 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_29 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_29 = new Vector3( (float)-466, (float)299, (float)0 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_29 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_29 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_29 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_31 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_31 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_31 = new Vector3( (float)-466, (float)127, (float)0 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_31 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_31 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_31 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_8 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_11 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_14 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_23 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_27 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_32 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_0_UnityEngine_GameObject = GameObject.Find( "credits" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_9_UnityEngine_GameObject = GameObject.Find( "select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_15_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_15_UnityEngine_GameObject = GameObject.Find( "credits" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_15_UnityEngine_GameObject_previous != local_15_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_15_UnityEngine_GameObject_previous = local_15_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_30_UnityEngine_GameObject = GameObject.Find( "select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_15_UnityEngine_GameObject_previous != local_15_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_15_UnityEngine_GameObject_previous = local_15_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_8 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_8 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_8 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_8.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_8.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_8;
                  component.OnLateUpdate += Instance_OnLateUpdate_8;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_8;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_11 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_11 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_11 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_11.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_11.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_11;
                  component.OnLateUpdate += Instance_OnLateUpdate_11;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_11;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_14 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_14 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_14 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_14.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_14.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_14;
                  component.OnLateUpdate += Instance_OnLateUpdate_14;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_14;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_23 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_23 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_23 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_23.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_23.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_23;
                  component.OnLateUpdate += Instance_OnLateUpdate_23;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_23;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_27 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_27 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_27 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_27.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_27.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_27;
                  component.OnLateUpdate += Instance_OnLateUpdate_27;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_27;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_32 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_32 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_32 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_32.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_32.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_32;
                  component.OnLateUpdate += Instance_OnLateUpdate_32;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_32;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_8 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_8.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_8;
               component.OnLateUpdate -= Instance_OnLateUpdate_8;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_8;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_11 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_11.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_11;
               component.OnLateUpdate -= Instance_OnLateUpdate_11;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_11;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_14 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_14.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_14;
               component.OnLateUpdate -= Instance_OnLateUpdate_14;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_14;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_23 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_23.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_23;
               component.OnLateUpdate -= Instance_OnLateUpdate_23;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_23;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_27 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_27.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_27;
               component.OnLateUpdate -= Instance_OnLateUpdate_27;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_27;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_32 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_32.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_32;
               component.OnLateUpdate -= Instance_OnLateUpdate_32;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_32;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_AnimatorPlay_uScriptAct_AnimatorPlay_1.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_3.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_4.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_7.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_10.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_12.SetParent(g);
      logic_uScriptAct_AnimatorPlay_uScriptAct_AnimatorPlay_13.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_18.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_20.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_21.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_24.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_25.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_29.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_31.SetParent(g);
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnUpdate_8(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_8( );
   }
   
   void Instance_OnLateUpdate_8(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_8( );
   }
   
   void Instance_OnFixedUpdate_8(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_8( );
   }
   
   void Instance_OnUpdate_11(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_11( );
   }
   
   void Instance_OnLateUpdate_11(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_11( );
   }
   
   void Instance_OnFixedUpdate_11(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_11( );
   }
   
   void Instance_OnUpdate_14(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_14( );
   }
   
   void Instance_OnLateUpdate_14(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_14( );
   }
   
   void Instance_OnFixedUpdate_14(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_14( );
   }
   
   void Instance_OnUpdate_23(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_23( );
   }
   
   void Instance_OnLateUpdate_23(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_23( );
   }
   
   void Instance_OnFixedUpdate_23(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_23( );
   }
   
   void Instance_OnUpdate_27(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_27( );
   }
   
   void Instance_OnLateUpdate_27(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_27( );
   }
   
   void Instance_OnFixedUpdate_27(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_27( );
   }
   
   void Instance_OnUpdate_32(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_32( );
   }
   
   void Instance_OnLateUpdate_32(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_32( );
   }
   
   void Instance_OnFixedUpdate_32(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_32( );
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("68a454ed-1ede-4d6f-9a20-4881036e1e1d", "Animator_Play", Relay_In_1)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_AnimatorPlay_Target_1.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AnimatorPlay_Target_1, index + 1);
               }
               logic_uScriptAct_AnimatorPlay_Target_1[ index++ ] = local_0_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_AnimatorPlay_Name_1 = local_open_System_String;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AnimatorPlay_uScriptAct_AnimatorPlay_1.In(logic_uScriptAct_AnimatorPlay_Target_1, logic_uScriptAct_AnimatorPlay_Name_1, logic_uScriptAct_AnimatorPlay_Layer_1, logic_uScriptAct_AnimatorPlay_NormalizedTime_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AnimatorPlay_uScriptAct_AnimatorPlay_1.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Animator Play.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f06193d5-cff0-45dc-b8be-0398717b58a3", "Set_Int", Relay_In_3)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_3.In(logic_uScriptAct_SetInt_Value_3, out logic_uScriptAct_SetInt_Target_3);
         local_5_System_Int32 = logic_uScriptAct_SetInt_Target_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4789d8b8-b0c9-4ca7-84d9-1a948b3dd508", "Compare_Int", Relay_In_4)) return; 
         {
            {
            }
            {
               logic_uScriptCon_CompareInt_B_4 = local_5_System_Int32;
               
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_4.In(logic_uScriptCon_CompareInt_A_4, logic_uScriptCon_CompareInt_B_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_4.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("16ed019c-47ca-4e62-b7c8-61c9f7d25935", "Compare_Int", Relay_In_7)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_7 = local_cual_System_Int32;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_7.In(logic_uScriptCon_CompareInt_A_7, logic_uScriptCon_CompareInt_B_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_7.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_29();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_8()
   {
      if (true == CheckDebugBreak("5994e697-0d51-41e9-9a63-017c8d4c8083", "Global_Update", Relay_OnUpdate_8)) return; 
      Relay_In_7();
   }
   
   void Relay_OnLateUpdate_8()
   {
      if (true == CheckDebugBreak("5994e697-0d51-41e9-9a63-017c8d4c8083", "Global_Update", Relay_OnLateUpdate_8)) return; 
   }
   
   void Relay_OnFixedUpdate_8()
   {
      if (true == CheckDebugBreak("5994e697-0d51-41e9-9a63-017c8d4c8083", "Global_Update", Relay_OnFixedUpdate_8)) return; 
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("18267430-c1c1-4318-9da3-93e439aea739", "Compare_Int", Relay_In_10)) return; 
         {
            {
            }
            {
               logic_uScriptCon_CompareInt_B_10 = local_cual_System_Int32;
               
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_10.In(logic_uScriptCon_CompareInt_A_10, logic_uScriptCon_CompareInt_B_10);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_10.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_31();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_11()
   {
      if (true == CheckDebugBreak("c3b651ac-f5db-43f8-bf48-ebddf2d86a08", "Global_Update", Relay_OnUpdate_11)) return; 
      Relay_In_12();
   }
   
   void Relay_OnLateUpdate_11()
   {
      if (true == CheckDebugBreak("c3b651ac-f5db-43f8-bf48-ebddf2d86a08", "Global_Update", Relay_OnLateUpdate_11)) return; 
   }
   
   void Relay_OnFixedUpdate_11()
   {
      if (true == CheckDebugBreak("c3b651ac-f5db-43f8-bf48-ebddf2d86a08", "Global_Update", Relay_OnFixedUpdate_11)) return; 
   }
   
   void Relay_In_12()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1909d169-d1ed-4b1b-902d-3222d9fe9ab6", "Input_Events_Filter", Relay_In_12)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_12.In(logic_uScriptAct_OnInputEventFilter_KeyCode_12);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_12.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_21();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3c76f015-8c58-4a7d-a2e3-4a0e75b3b082", "Animator_Play", Relay_In_13)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_15_UnityEngine_GameObject_previous != local_15_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_15_UnityEngine_GameObject_previous = local_15_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_AnimatorPlay_Target_13.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AnimatorPlay_Target_13, index + 1);
               }
               logic_uScriptAct_AnimatorPlay_Target_13[ index++ ] = local_15_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_AnimatorPlay_Name_13 = local_closed_System_String;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AnimatorPlay_uScriptAct_AnimatorPlay_13.In(logic_uScriptAct_AnimatorPlay_Target_13, logic_uScriptAct_AnimatorPlay_Name_13, logic_uScriptAct_AnimatorPlay_Layer_13, logic_uScriptAct_AnimatorPlay_NormalizedTime_13);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AnimatorPlay_uScriptAct_AnimatorPlay_13.Out;
         
         if ( test_0 == true )
         {
            Relay_In_20();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Animator Play.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_14()
   {
      if (true == CheckDebugBreak("61d6d00c-c029-432f-bcf8-648e89c2750c", "Global_Update", Relay_OnUpdate_14)) return; 
      Relay_In_17();
   }
   
   void Relay_OnLateUpdate_14()
   {
      if (true == CheckDebugBreak("61d6d00c-c029-432f-bcf8-648e89c2750c", "Global_Update", Relay_OnLateUpdate_14)) return; 
   }
   
   void Relay_OnFixedUpdate_14()
   {
      if (true == CheckDebugBreak("61d6d00c-c029-432f-bcf8-648e89c2750c", "Global_Update", Relay_OnFixedUpdate_14)) return; 
   }
   
   void Relay_In_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("625f4c1c-2d54-4cb9-b9eb-5956210abc12", "Input_Events_Filter", Relay_In_17)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.In(logic_uScriptAct_OnInputEventFilter_KeyCode_17);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.KeyUp;
         
         if ( test_0 == true )
         {
            Relay_In_18();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9499a00c-aeff-4f7e-8756-32a8518dca9b", "Compare_Int", Relay_In_18)) return; 
         {
            {
            }
            {
               logic_uScriptCon_CompareInt_B_18 = local_19_System_Int32;
               
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_18.In(logic_uScriptCon_CompareInt_A_18, logic_uScriptCon_CompareInt_B_18);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_18.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_13();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c5025e37-4988-4c6e-bb9f-e5dfac833c21", "Set_Int", Relay_In_20)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_20.In(logic_uScriptAct_SetInt_Value_20, out logic_uScriptAct_SetInt_Target_20);
         local_19_System_Int32 = logic_uScriptAct_SetInt_Target_20;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f476ae2e-15e3-4c2c-a4a8-4fb8ba64c326", "Set_Int", Relay_In_21)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_21.In(logic_uScriptAct_SetInt_Value_21, out logic_uScriptAct_SetInt_Target_21);
         local_cual_System_Int32 = logic_uScriptAct_SetInt_Target_21;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_23()
   {
      if (true == CheckDebugBreak("340851c2-4098-47d5-ab59-dc6a2d4b7667", "Global_Update", Relay_OnUpdate_23)) return; 
      Relay_In_10();
   }
   
   void Relay_OnLateUpdate_23()
   {
      if (true == CheckDebugBreak("340851c2-4098-47d5-ab59-dc6a2d4b7667", "Global_Update", Relay_OnLateUpdate_23)) return; 
   }
   
   void Relay_OnFixedUpdate_23()
   {
      if (true == CheckDebugBreak("340851c2-4098-47d5-ab59-dc6a2d4b7667", "Global_Update", Relay_OnFixedUpdate_23)) return; 
   }
   
   void Relay_In_24()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8d30eb2c-e364-43fc-941f-2661a9a360ad", "Set_Int", Relay_In_24)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_24.In(logic_uScriptAct_SetInt_Value_24, out logic_uScriptAct_SetInt_Target_24);
         local_cual_System_Int32 = logic_uScriptAct_SetInt_Target_24;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_25()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("82e41941-6fcc-4453-854d-1fcd56c01b0a", "Input_Events_Filter", Relay_In_25)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_25.In(logic_uScriptAct_OnInputEventFilter_KeyCode_25);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_25.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_24();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_27()
   {
      if (true == CheckDebugBreak("bb9872d5-78f5-406b-a5ae-831897c73e33", "Global_Update", Relay_OnUpdate_27)) return; 
      Relay_In_25();
   }
   
   void Relay_OnLateUpdate_27()
   {
      if (true == CheckDebugBreak("bb9872d5-78f5-406b-a5ae-831897c73e33", "Global_Update", Relay_OnLateUpdate_27)) return; 
   }
   
   void Relay_OnFixedUpdate_27()
   {
      if (true == CheckDebugBreak("bb9872d5-78f5-406b-a5ae-831897c73e33", "Global_Update", Relay_OnFixedUpdate_27)) return; 
   }
   
   void Relay_In_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c787e652-b50e-419e-b220-1c2c320a85ac", "Set_Position", Relay_In_29)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_SetGameObjectPosition_Target_29.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_29, index + 1);
               }
               logic_uScriptAct_SetGameObjectPosition_Target_29[ index++ ] = local_30_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_29.In(logic_uScriptAct_SetGameObjectPosition_Target_29, logic_uScriptAct_SetGameObjectPosition_Position_29, logic_uScriptAct_SetGameObjectPosition_AsOffset_29, logic_uScriptAct_SetGameObjectPosition_AsLocal_29);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Set Position.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_31()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ae00e120-99d4-42cb-9bab-fd695e4ecdf2", "Set_Position", Relay_In_31)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_SetGameObjectPosition_Target_31.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_31, index + 1);
               }
               logic_uScriptAct_SetGameObjectPosition_Target_31[ index++ ] = local_9_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_31.In(logic_uScriptAct_SetGameObjectPosition_Target_31, logic_uScriptAct_SetGameObjectPosition_Position_31, logic_uScriptAct_SetGameObjectPosition_AsOffset_31, logic_uScriptAct_SetGameObjectPosition_AsLocal_31);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript menuscript.uscript at Set Position.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_32()
   {
      if (true == CheckDebugBreak("7936a903-b70d-41af-bd8e-7cc8e1496068", "Global_Update", Relay_OnUpdate_32)) return; 
      Relay_In_4();
   }
   
   void Relay_OnLateUpdate_32()
   {
      if (true == CheckDebugBreak("7936a903-b70d-41af-bd8e-7cc8e1496068", "Global_Update", Relay_OnLateUpdate_32)) return; 
   }
   
   void Relay_OnFixedUpdate_32()
   {
      if (true == CheckDebugBreak("7936a903-b70d-41af-bd8e-7cc8e1496068", "Global_Update", Relay_OnFixedUpdate_32)) return; 
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "menuscript.uscript:0", local_0_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "322dbcb2-cba0-4ada-b18f-4b8908000b1d", local_0_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "menuscript.uscript:open", local_open_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "48183ea0-a14e-4007-be8f-7d5896b9110e", local_open_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "menuscript.uscript:5", local_5_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "324233b4-4fe1-46c1-bbe8-9fbba28f7607", local_5_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "menuscript.uscript:9", local_9_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "225ba7b9-725a-44eb-87aa-03f25fc0326d", local_9_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "menuscript.uscript:15", local_15_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "35ba89df-370b-4d77-95f4-fdfc080fdf14", local_15_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "menuscript.uscript:closed", local_closed_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "080d7871-200e-4977-9bae-ece920b03330", local_closed_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "menuscript.uscript:19", local_19_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "827104c7-cd62-4348-8318-d39691743f3e", local_19_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "menuscript.uscript:cual", local_cual_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7a2e6c72-c8c0-4d71-bb7d-eeb8f5adda16", local_cual_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "menuscript.uscript:30", local_30_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ee664cb0-8d8c-45ac-a64c-2d9438678e08", local_30_UnityEngine_GameObject);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
