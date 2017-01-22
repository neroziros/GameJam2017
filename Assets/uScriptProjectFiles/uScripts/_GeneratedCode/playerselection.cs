//uScript Generated Code - Build 1.0.3036
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class playerselection : uScriptLogic
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
   UnityEngine.GameObject local_10_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_10_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_11_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_11_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_16_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_16_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_17_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_17_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_18_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_18_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_19_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_19_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_8_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_8_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_9_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_9_UnityEngine_GameObject_previous = null;
   System.Int32 local_players_System_Int32 = (int) 0;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_0 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_0 = UnityEngine.KeyCode.Joystick1Button1;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_0 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_0 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_0 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_1 = UnityEngine.KeyCode.Joystick2Button1;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_1 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_1 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_1 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_2 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_2 = UnityEngine.KeyCode.Joystick3Button1;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_2 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_2 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_2 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_3 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_3 = UnityEngine.KeyCode.Joystick4Button1;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_3 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_3 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_3 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_4 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_4 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_4 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_5 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_5 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_5 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_6 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_6 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_6 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_7 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_7 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_7 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_15 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_15 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_15 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_37 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_37 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_B_37 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_37;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_37;
   bool logic_uScriptAct_AddInt_v2_Out_37 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_49 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_49 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_49 = (int) 4;
   bool logic_uScriptCon_CompareInt_GreaterThan_49 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_49 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_49 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_49 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_49 = true;
   bool logic_uScriptCon_CompareInt_LessThan_49 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_12 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_13 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_14 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_20 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_21 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_8_UnityEngine_GameObject = GameObject.Find( "player1select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_9_UnityEngine_GameObject = GameObject.Find( "player2select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_10_UnityEngine_GameObject = GameObject.Find( "player3select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_11_UnityEngine_GameObject = GameObject.Find( "player4select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_16_UnityEngine_GameObject = GameObject.Find( "player1select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_17_UnityEngine_GameObject = GameObject.Find( "player2select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_18_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_18_UnityEngine_GameObject = GameObject.Find( "player3select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_18_UnityEngine_GameObject_previous != local_18_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_18_UnityEngine_GameObject_previous = local_18_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_19_UnityEngine_GameObject = GameObject.Find( "player4select" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
         
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
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_18_UnityEngine_GameObject_previous != local_18_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_18_UnityEngine_GameObject_previous = local_18_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_12 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_12 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_12 )
         {
            {
               uScript_Global component = event_UnityEngine_GameObject_Instance_12.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_12.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_12;
                  component.uScriptLateStart += Instance_uScriptLateStart_12;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_13 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_13 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_13 )
         {
            {
               uScript_Input component = event_UnityEngine_GameObject_Instance_13.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_13.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_13;
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
               uScript_Input component = event_UnityEngine_GameObject_Instance_14.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_14.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_14;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_20 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_20 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_20 )
         {
            {
               uScript_Input component = event_UnityEngine_GameObject_Instance_20.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_20.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_20;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_21 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_21 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_21 )
         {
            {
               uScript_Input component = event_UnityEngine_GameObject_Instance_21.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_21.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_21;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_12 )
      {
         {
            uScript_Global component = event_UnityEngine_GameObject_Instance_12.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_12;
               component.uScriptLateStart -= Instance_uScriptLateStart_12;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_13 )
      {
         {
            uScript_Input component = event_UnityEngine_GameObject_Instance_13.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_13;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_14 )
      {
         {
            uScript_Input component = event_UnityEngine_GameObject_Instance_14.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_14;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_20 )
      {
         {
            uScript_Input component = event_UnityEngine_GameObject_Instance_20.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_20;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_21 )
      {
         {
            uScript_Input component = event_UnityEngine_GameObject_Instance_21.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_21;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_0.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_2.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_3.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_5.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_15.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_37.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_49.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.OnOut += uScriptAct_Toggle_OnOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.OffOut += uScriptAct_Toggle_OffOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.ToggleOut += uScriptAct_Toggle_ToggleOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_5.OnOut += uScriptAct_Toggle_OnOut_5;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_5.OffOut += uScriptAct_Toggle_OffOut_5;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_5.ToggleOut += uScriptAct_Toggle_ToggleOut_5;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OnOut += uScriptAct_Toggle_OnOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OffOut += uScriptAct_Toggle_OffOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.ToggleOut += uScriptAct_Toggle_ToggleOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OnOut += uScriptAct_Toggle_OnOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OffOut += uScriptAct_Toggle_OffOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.ToggleOut += uScriptAct_Toggle_ToggleOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_15.OnOut += uScriptAct_Toggle_OnOut_15;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_15.OffOut += uScriptAct_Toggle_OffOut_15;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_15.ToggleOut += uScriptAct_Toggle_ToggleOut_15;
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
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.OnOut -= uScriptAct_Toggle_OnOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.OffOut -= uScriptAct_Toggle_OffOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.ToggleOut -= uScriptAct_Toggle_ToggleOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_5.OnOut -= uScriptAct_Toggle_OnOut_5;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_5.OffOut -= uScriptAct_Toggle_OffOut_5;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_5.ToggleOut -= uScriptAct_Toggle_ToggleOut_5;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OnOut -= uScriptAct_Toggle_OnOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OffOut -= uScriptAct_Toggle_OffOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.ToggleOut -= uScriptAct_Toggle_ToggleOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OnOut -= uScriptAct_Toggle_OnOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OffOut -= uScriptAct_Toggle_OffOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.ToggleOut -= uScriptAct_Toggle_ToggleOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_15.OnOut -= uScriptAct_Toggle_OnOut_15;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_15.OffOut -= uScriptAct_Toggle_OffOut_15;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_15.ToggleOut -= uScriptAct_Toggle_ToggleOut_15;
   }
   
   void Instance_uScriptStart_12(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_12( );
   }
   
   void Instance_uScriptLateStart_12(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_12( );
   }
   
   void Instance_KeyEvent_13(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_13( );
   }
   
   void Instance_KeyEvent_14(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_14( );
   }
   
   void Instance_KeyEvent_20(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_20( );
   }
   
   void Instance_KeyEvent_21(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_21( );
   }
   
   void uScriptAct_Toggle_OnOut_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_4( );
   }
   
   void uScriptAct_Toggle_OffOut_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_4( );
   }
   
   void uScriptAct_Toggle_ToggleOut_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_4( );
   }
   
   void uScriptAct_Toggle_OnOut_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_5( );
   }
   
   void uScriptAct_Toggle_OffOut_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_5( );
   }
   
   void uScriptAct_Toggle_ToggleOut_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_5( );
   }
   
   void uScriptAct_Toggle_OnOut_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_6( );
   }
   
   void uScriptAct_Toggle_OffOut_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_6( );
   }
   
   void uScriptAct_Toggle_ToggleOut_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_6( );
   }
   
   void uScriptAct_Toggle_OnOut_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_7( );
   }
   
   void uScriptAct_Toggle_OffOut_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_7( );
   }
   
   void uScriptAct_Toggle_ToggleOut_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_7( );
   }
   
   void uScriptAct_Toggle_OnOut_15(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_15( );
   }
   
   void uScriptAct_Toggle_OffOut_15(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_15( );
   }
   
   void uScriptAct_Toggle_ToggleOut_15(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_15( );
   }
   
   void Relay_In_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9ed57aa6-1386-4466-b3f3-040e0cccdb0a", "Input_Events_Filter", Relay_In_0)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_0.In(logic_uScriptAct_OnInputEventFilter_KeyCode_0);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_0.KeyUp;
         
         if ( test_0 == true )
         {
            Relay_TurnOn_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("07992a3e-c0ca-4236-b41a-f2528d6bc436", "Input_Events_Filter", Relay_In_1)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.In(logic_uScriptAct_OnInputEventFilter_KeyCode_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("399ec288-2155-4825-a5da-434b135e1c51", "Input_Events_Filter", Relay_In_2)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_2.In(logic_uScriptAct_OnInputEventFilter_KeyCode_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bf8a5e9d-6a22-474c-877d-84db7b2b6864", "Input_Events_Filter", Relay_In_3)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_3.In(logic_uScriptAct_OnInputEventFilter_KeyCode_3);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnOut_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("750bf439-b415-45aa-a4ea-cebab62fb8c9", "Toggle", Relay_OnOut_4)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("750bf439-b415-45aa-a4ea-cebab62fb8c9", "Toggle", Relay_OffOut_4)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("750bf439-b415-45aa-a4ea-cebab62fb8c9", "Toggle", Relay_ToggleOut_4)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("750bf439-b415-45aa-a4ea-cebab62fb8c9", "Toggle", Relay_TurnOn_4)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_4, index + 1);
               }
               logic_uScriptAct_Toggle_Target_4[ index++ ] = local_10_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_4.TurnOn(logic_uScriptAct_Toggle_Target_4, logic_uScriptAct_Toggle_IgnoreChildren_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("750bf439-b415-45aa-a4ea-cebab62fb8c9", "Toggle", Relay_TurnOff_4)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_4, index + 1);
               }
               logic_uScriptAct_Toggle_Target_4[ index++ ] = local_10_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_4.TurnOff(logic_uScriptAct_Toggle_Target_4, logic_uScriptAct_Toggle_IgnoreChildren_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("750bf439-b415-45aa-a4ea-cebab62fb8c9", "Toggle", Relay_Toggle_4)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_4, index + 1);
               }
               logic_uScriptAct_Toggle_Target_4[ index++ ] = local_10_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_4.Toggle(logic_uScriptAct_Toggle_Target_4, logic_uScriptAct_Toggle_IgnoreChildren_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnOut_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1719916e-eaad-41c0-9ed2-b995d49ed526", "Toggle", Relay_OnOut_5)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1719916e-eaad-41c0-9ed2-b995d49ed526", "Toggle", Relay_OffOut_5)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1719916e-eaad-41c0-9ed2-b995d49ed526", "Toggle", Relay_ToggleOut_5)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1719916e-eaad-41c0-9ed2-b995d49ed526", "Toggle", Relay_TurnOn_5)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_5.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_5, index + 1);
               }
               logic_uScriptAct_Toggle_Target_5[ index++ ] = local_11_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_5.TurnOn(logic_uScriptAct_Toggle_Target_5, logic_uScriptAct_Toggle_IgnoreChildren_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1719916e-eaad-41c0-9ed2-b995d49ed526", "Toggle", Relay_TurnOff_5)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_5.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_5, index + 1);
               }
               logic_uScriptAct_Toggle_Target_5[ index++ ] = local_11_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_5.TurnOff(logic_uScriptAct_Toggle_Target_5, logic_uScriptAct_Toggle_IgnoreChildren_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1719916e-eaad-41c0-9ed2-b995d49ed526", "Toggle", Relay_Toggle_5)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_5.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_5, index + 1);
               }
               logic_uScriptAct_Toggle_Target_5[ index++ ] = local_11_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_5.Toggle(logic_uScriptAct_Toggle_Target_5, logic_uScriptAct_Toggle_IgnoreChildren_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnOut_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b39e614f-6868-434b-a399-28f6741535c2", "Toggle", Relay_OnOut_6)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b39e614f-6868-434b-a399-28f6741535c2", "Toggle", Relay_OffOut_6)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b39e614f-6868-434b-a399-28f6741535c2", "Toggle", Relay_ToggleOut_6)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b39e614f-6868-434b-a399-28f6741535c2", "Toggle", Relay_TurnOn_6)) return; 
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
               if ( logic_uScriptAct_Toggle_Target_6.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_6, index + 1);
               }
               logic_uScriptAct_Toggle_Target_6[ index++ ] = local_9_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_6.TurnOn(logic_uScriptAct_Toggle_Target_6, logic_uScriptAct_Toggle_IgnoreChildren_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b39e614f-6868-434b-a399-28f6741535c2", "Toggle", Relay_TurnOff_6)) return; 
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
               if ( logic_uScriptAct_Toggle_Target_6.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_6, index + 1);
               }
               logic_uScriptAct_Toggle_Target_6[ index++ ] = local_9_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_6.TurnOff(logic_uScriptAct_Toggle_Target_6, logic_uScriptAct_Toggle_IgnoreChildren_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b39e614f-6868-434b-a399-28f6741535c2", "Toggle", Relay_Toggle_6)) return; 
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
               if ( logic_uScriptAct_Toggle_Target_6.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_6, index + 1);
               }
               logic_uScriptAct_Toggle_Target_6[ index++ ] = local_9_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_6.Toggle(logic_uScriptAct_Toggle_Target_6, logic_uScriptAct_Toggle_IgnoreChildren_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnOut_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("46f6d7ca-4779-4df0-898c-5a9df92c7f20", "Toggle", Relay_OnOut_7)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("46f6d7ca-4779-4df0-898c-5a9df92c7f20", "Toggle", Relay_OffOut_7)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("46f6d7ca-4779-4df0-898c-5a9df92c7f20", "Toggle", Relay_ToggleOut_7)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("46f6d7ca-4779-4df0-898c-5a9df92c7f20", "Toggle", Relay_TurnOn_7)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_7.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_7, index + 1);
               }
               logic_uScriptAct_Toggle_Target_7[ index++ ] = local_8_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_7.TurnOn(logic_uScriptAct_Toggle_Target_7, logic_uScriptAct_Toggle_IgnoreChildren_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Toggle_uScriptAct_Toggle_7.Out;
         
         if ( test_0 == true )
         {
            Relay_In_37();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("46f6d7ca-4779-4df0-898c-5a9df92c7f20", "Toggle", Relay_TurnOff_7)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_7.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_7, index + 1);
               }
               logic_uScriptAct_Toggle_Target_7[ index++ ] = local_8_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_7.TurnOff(logic_uScriptAct_Toggle_Target_7, logic_uScriptAct_Toggle_IgnoreChildren_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Toggle_uScriptAct_Toggle_7.Out;
         
         if ( test_0 == true )
         {
            Relay_In_37();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("46f6d7ca-4779-4df0-898c-5a9df92c7f20", "Toggle", Relay_Toggle_7)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_7.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_7, index + 1);
               }
               logic_uScriptAct_Toggle_Target_7[ index++ ] = local_8_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_7.Toggle(logic_uScriptAct_Toggle_Target_7, logic_uScriptAct_Toggle_IgnoreChildren_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Toggle_uScriptAct_Toggle_7.Out;
         
         if ( test_0 == true )
         {
            Relay_In_37();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_uScriptStart_12()
   {
      if (true == CheckDebugBreak("43228a32-22e1-4929-8aeb-e1e5745d6e8c", "uScript_Events", Relay_uScriptStart_12)) return; 
      Relay_TurnOff_15();
   }
   
   void Relay_uScriptLateStart_12()
   {
      if (true == CheckDebugBreak("43228a32-22e1-4929-8aeb-e1e5745d6e8c", "uScript_Events", Relay_uScriptLateStart_12)) return; 
   }
   
   void Relay_KeyEvent_13()
   {
      if (true == CheckDebugBreak("2fcad6b3-193e-4dca-ad7a-a9d143e6608c", "Input_Events", Relay_KeyEvent_13)) return; 
      Relay_In_0();
   }
   
   void Relay_KeyEvent_14()
   {
      if (true == CheckDebugBreak("799af2f4-4111-4cbf-8737-e54a73291250", "Input_Events", Relay_KeyEvent_14)) return; 
      Relay_In_1();
   }
   
   void Relay_OnOut_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("acbc2276-81d2-44eb-92a9-406d4ae8bdb9", "Toggle", Relay_OnOut_15)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("acbc2276-81d2-44eb-92a9-406d4ae8bdb9", "Toggle", Relay_OffOut_15)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("acbc2276-81d2-44eb-92a9-406d4ae8bdb9", "Toggle", Relay_ToggleOut_15)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("acbc2276-81d2-44eb-92a9-406d4ae8bdb9", "Toggle", Relay_TurnOn_15)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_16_UnityEngine_GameObject;
               
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_17_UnityEngine_GameObject;
               
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_18_UnityEngine_GameObject_previous != local_18_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_18_UnityEngine_GameObject_previous = local_18_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_18_UnityEngine_GameObject;
               
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_19_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_15.TurnOn(logic_uScriptAct_Toggle_Target_15, logic_uScriptAct_Toggle_IgnoreChildren_15);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("acbc2276-81d2-44eb-92a9-406d4ae8bdb9", "Toggle", Relay_TurnOff_15)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_16_UnityEngine_GameObject;
               
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_17_UnityEngine_GameObject;
               
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_18_UnityEngine_GameObject_previous != local_18_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_18_UnityEngine_GameObject_previous = local_18_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_18_UnityEngine_GameObject;
               
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_19_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_15.TurnOff(logic_uScriptAct_Toggle_Target_15, logic_uScriptAct_Toggle_IgnoreChildren_15);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("acbc2276-81d2-44eb-92a9-406d4ae8bdb9", "Toggle", Relay_Toggle_15)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_16_UnityEngine_GameObject;
               
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_17_UnityEngine_GameObject;
               
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_18_UnityEngine_GameObject_previous != local_18_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_18_UnityEngine_GameObject_previous = local_18_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_18_UnityEngine_GameObject;
               
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_15, index + 1);
               }
               logic_uScriptAct_Toggle_Target_15[ index++ ] = local_19_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_15.Toggle(logic_uScriptAct_Toggle_Target_15, logic_uScriptAct_Toggle_IgnoreChildren_15);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_KeyEvent_20()
   {
      if (true == CheckDebugBreak("e003490b-4660-4aac-bdb2-28268e2a459d", "Input_Events", Relay_KeyEvent_20)) return; 
      Relay_In_3();
   }
   
   void Relay_KeyEvent_21()
   {
      if (true == CheckDebugBreak("afb18048-ffd3-4e49-8cb9-6df600f1da27", "Input_Events", Relay_KeyEvent_21)) return; 
      Relay_In_2();
   }
   
   void Relay_In_37()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("6e4615de-70f5-4cf0-9220-20a849fa5ec5", "Add_Int", Relay_In_37)) return; 
         {
            {
               logic_uScriptAct_AddInt_v2_A_37 = local_players_System_Int32;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_37.In(logic_uScriptAct_AddInt_v2_A_37, logic_uScriptAct_AddInt_v2_B_37, out logic_uScriptAct_AddInt_v2_IntResult_37, out logic_uScriptAct_AddInt_v2_FloatResult_37);
         local_players_System_Int32 = logic_uScriptAct_AddInt_v2_IntResult_37;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Add Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_49()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e076581d-79b1-405a-906e-19ede4fddb60", "Compare_Int", Relay_In_49)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_49 = local_players_System_Int32;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_49.In(logic_uScriptCon_CompareInt_A_49, logic_uScriptCon_CompareInt_B_49);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerselection.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerselection.uscript:8", local_8_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c88ea41f-4f00-42c5-81c4-d3cbf858a47a", local_8_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerselection.uscript:9", local_9_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9edb10df-44ee-4cad-9d08-4df85e1e8c55", local_9_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerselection.uscript:10", local_10_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c89dd0a4-f7f9-498b-a478-e4c55c2aae22", local_10_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerselection.uscript:11", local_11_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f6688ed0-152a-41c5-8e04-4f4c7af14818", local_11_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerselection.uscript:16", local_16_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "add7fa11-dd74-4d08-8331-83629bdff5a3", local_16_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerselection.uscript:17", local_17_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b354f63e-ca33-460d-b996-c51627e6fa26", local_17_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerselection.uscript:18", local_18_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "d065114b-7edc-4beb-ac7c-5b49cb358f6c", local_18_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerselection.uscript:19", local_19_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7f6c0f80-85d0-413d-9d03-2351e289af4e", local_19_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerselection.uscript:players", local_players_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "28830fbf-6993-4f9a-bf06-910872131123", local_players_System_Int32);
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
