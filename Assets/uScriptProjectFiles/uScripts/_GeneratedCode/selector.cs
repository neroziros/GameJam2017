//uScript Generated Code - Build 1.0.3036
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class selector : uScriptLogic
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
   public UnityEngine.GameObject credit = default(UnityEngine.GameObject);
   UnityEngine.GameObject credit_previous = null;
   public UnityEngine.GameObject play = default(UnityEngine.GameObject);
   UnityEngine.GameObject play_previous = null;
   public System.Int32 selectorVar = (int) 1;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_3 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_3 = (int) 1;
   System.Int32 logic_uScriptCon_CompareInt_B_3 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_3 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_3 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_3 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_3 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_3 = true;
   bool logic_uScriptCon_CompareInt_LessThan_3 = true;
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
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_8 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_8 = (int) 2;
   System.Int32 logic_uScriptCon_CompareInt_B_8 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_8 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_8 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_8 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_8 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_8 = true;
   bool logic_uScriptCon_CompareInt_LessThan_8 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_9 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_9 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_9 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_9 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_11 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_11 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_11 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_11 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_28 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_28 = UnityEngine.KeyCode.A;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_28 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_28 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_28 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_29 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_29 = UnityEngine.KeyCode.S;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_29 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_29 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_29 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_35 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_35 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_35 = (int) 2;
   bool logic_uScriptCon_CompareInt_GreaterThan_35 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_35 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_35 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_35 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_35 = true;
   bool logic_uScriptCon_CompareInt_LessThan_35 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_38 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_38 = (int) 1;
   System.Int32 logic_uScriptAct_SetInt_Target_38;
   bool logic_uScriptAct_SetInt_Out_38 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_41 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_41 = (int) 2;
   System.Int32 logic_uScriptAct_SetInt_Target_41;
   bool logic_uScriptAct_SetInt_Out_41 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_43 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_43 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_43 = (int) 1;
   bool logic_uScriptCon_CompareInt_GreaterThan_43 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_43 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_43 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_43 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_43 = true;
   bool logic_uScriptCon_CompareInt_LessThan_43 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_10 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_30 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_32 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == play || false == m_RegisteredForEvents )
      {
         play = GameObject.Find( "selectPlay" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( play_previous != play || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         play_previous = play;
         
         //setup new listeners
      }
      if ( null == credit || false == m_RegisteredForEvents )
      {
         credit = GameObject.Find( "selectCredits" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( credit_previous != credit || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         credit_previous = credit;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( play_previous != play || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         play_previous = play;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( credit_previous != credit || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         credit_previous = credit;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_0;
                  component.OnLateUpdate += Instance_OnLateUpdate_0;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_0;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_10 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_10 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_10 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_10.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_10.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_10;
                  component.OnLateUpdate += Instance_OnLateUpdate_10;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_10;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_30 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_30 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_30 )
         {
            {
               uScript_Input component = event_UnityEngine_GameObject_Instance_30.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_30.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_30;
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
               uScript_Input component = event_UnityEngine_GameObject_Instance_32.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_32.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_32;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_0;
               component.OnLateUpdate -= Instance_OnLateUpdate_0;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_0;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_10 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_10.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_10;
               component.OnLateUpdate -= Instance_OnLateUpdate_10;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_30 )
      {
         {
            uScript_Input component = event_UnityEngine_GameObject_Instance_30.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_30;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_32 )
      {
         {
            uScript_Input component = event_UnityEngine_GameObject_Instance_32.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_32;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_3.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_8.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_9.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_11.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_28.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_29.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_35.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_38.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_41.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_43.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OnOut += uScriptAct_Toggle_OnOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OffOut += uScriptAct_Toggle_OffOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.ToggleOut += uScriptAct_Toggle_ToggleOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OnOut += uScriptAct_Toggle_OnOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OffOut += uScriptAct_Toggle_OffOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.ToggleOut += uScriptAct_Toggle_ToggleOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_9.OnOut += uScriptAct_Toggle_OnOut_9;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_9.OffOut += uScriptAct_Toggle_OffOut_9;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_9.ToggleOut += uScriptAct_Toggle_ToggleOut_9;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_11.OnOut += uScriptAct_Toggle_OnOut_11;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_11.OffOut += uScriptAct_Toggle_OffOut_11;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_11.ToggleOut += uScriptAct_Toggle_ToggleOut_11;
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
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OnOut -= uScriptAct_Toggle_OnOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OffOut -= uScriptAct_Toggle_OffOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.ToggleOut -= uScriptAct_Toggle_ToggleOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OnOut -= uScriptAct_Toggle_OnOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OffOut -= uScriptAct_Toggle_OffOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.ToggleOut -= uScriptAct_Toggle_ToggleOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_9.OnOut -= uScriptAct_Toggle_OnOut_9;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_9.OffOut -= uScriptAct_Toggle_OffOut_9;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_9.ToggleOut -= uScriptAct_Toggle_ToggleOut_9;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_11.OnOut -= uScriptAct_Toggle_OnOut_11;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_11.OffOut -= uScriptAct_Toggle_OffOut_11;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_11.ToggleOut -= uScriptAct_Toggle_ToggleOut_11;
   }
   
   void Instance_OnUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_0( );
   }
   
   void Instance_OnLateUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_0( );
   }
   
   void Instance_OnFixedUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_0( );
   }
   
   void Instance_OnUpdate_10(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_10( );
   }
   
   void Instance_OnLateUpdate_10(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_10( );
   }
   
   void Instance_OnFixedUpdate_10(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_10( );
   }
   
   void Instance_KeyEvent_30(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_30( );
   }
   
   void Instance_KeyEvent_32(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_32( );
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
   
   void uScriptAct_Toggle_OnOut_9(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_9( );
   }
   
   void uScriptAct_Toggle_OffOut_9(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_9( );
   }
   
   void uScriptAct_Toggle_ToggleOut_9(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_9( );
   }
   
   void uScriptAct_Toggle_OnOut_11(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_11( );
   }
   
   void uScriptAct_Toggle_OffOut_11(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_11( );
   }
   
   void uScriptAct_Toggle_ToggleOut_11(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_11( );
   }
   
   void Relay_OnUpdate_0()
   {
      if (true == CheckDebugBreak("d3bee254-77b7-4af2-bda9-4b8478de088c", "Global_Update", Relay_OnUpdate_0)) return; 
      Relay_In_3();
   }
   
   void Relay_OnLateUpdate_0()
   {
      if (true == CheckDebugBreak("d3bee254-77b7-4af2-bda9-4b8478de088c", "Global_Update", Relay_OnLateUpdate_0)) return; 
   }
   
   void Relay_OnFixedUpdate_0()
   {
      if (true == CheckDebugBreak("d3bee254-77b7-4af2-bda9-4b8478de088c", "Global_Update", Relay_OnFixedUpdate_0)) return; 
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e1ea8e0a-b89d-4e9c-932a-f9a5f607d441", "Compare_Int", Relay_In_3)) return; 
         {
            {
            }
            {
               logic_uScriptCon_CompareInt_B_3 = selectorVar;
               
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_3.In(logic_uScriptCon_CompareInt_A_3, logic_uScriptCon_CompareInt_B_3);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_3.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_TurnOn_6();
            Relay_TurnOff_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnOut_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a4d2c63d-08fc-4f9c-917e-bd6a6779155c", "Toggle", Relay_OnOut_6)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a4d2c63d-08fc-4f9c-917e-bd6a6779155c", "Toggle", Relay_OffOut_6)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a4d2c63d-08fc-4f9c-917e-bd6a6779155c", "Toggle", Relay_ToggleOut_6)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a4d2c63d-08fc-4f9c-917e-bd6a6779155c", "Toggle", Relay_TurnOn_6)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( credit_previous != credit || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     credit_previous = credit;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_6.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_6, index + 1);
               }
               logic_uScriptAct_Toggle_Target_6[ index++ ] = credit;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_6.TurnOn(logic_uScriptAct_Toggle_Target_6, logic_uScriptAct_Toggle_IgnoreChildren_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a4d2c63d-08fc-4f9c-917e-bd6a6779155c", "Toggle", Relay_TurnOff_6)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( credit_previous != credit || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     credit_previous = credit;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_6.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_6, index + 1);
               }
               logic_uScriptAct_Toggle_Target_6[ index++ ] = credit;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_6.TurnOff(logic_uScriptAct_Toggle_Target_6, logic_uScriptAct_Toggle_IgnoreChildren_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a4d2c63d-08fc-4f9c-917e-bd6a6779155c", "Toggle", Relay_Toggle_6)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( credit_previous != credit || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     credit_previous = credit;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_6.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_6, index + 1);
               }
               logic_uScriptAct_Toggle_Target_6[ index++ ] = credit;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_6.Toggle(logic_uScriptAct_Toggle_Target_6, logic_uScriptAct_Toggle_IgnoreChildren_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnOut_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56f1757e-f388-4f31-ad2e-97fb26e7a8b9", "Toggle", Relay_OnOut_7)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56f1757e-f388-4f31-ad2e-97fb26e7a8b9", "Toggle", Relay_OffOut_7)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56f1757e-f388-4f31-ad2e-97fb26e7a8b9", "Toggle", Relay_ToggleOut_7)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56f1757e-f388-4f31-ad2e-97fb26e7a8b9", "Toggle", Relay_TurnOn_7)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( play_previous != play || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     play_previous = play;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_7.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_7, index + 1);
               }
               logic_uScriptAct_Toggle_Target_7[ index++ ] = play;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_7.TurnOn(logic_uScriptAct_Toggle_Target_7, logic_uScriptAct_Toggle_IgnoreChildren_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56f1757e-f388-4f31-ad2e-97fb26e7a8b9", "Toggle", Relay_TurnOff_7)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( play_previous != play || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     play_previous = play;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_7.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_7, index + 1);
               }
               logic_uScriptAct_Toggle_Target_7[ index++ ] = play;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_7.TurnOff(logic_uScriptAct_Toggle_Target_7, logic_uScriptAct_Toggle_IgnoreChildren_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56f1757e-f388-4f31-ad2e-97fb26e7a8b9", "Toggle", Relay_Toggle_7)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( play_previous != play || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     play_previous = play;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_7.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_7, index + 1);
               }
               logic_uScriptAct_Toggle_Target_7[ index++ ] = play;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_7.Toggle(logic_uScriptAct_Toggle_Target_7, logic_uScriptAct_Toggle_IgnoreChildren_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4d21632d-ee80-4125-b13e-9e61e4ca2181", "Compare_Int", Relay_In_8)) return; 
         {
            {
            }
            {
               logic_uScriptCon_CompareInt_B_8 = selectorVar;
               
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_8.In(logic_uScriptCon_CompareInt_A_8, logic_uScriptCon_CompareInt_B_8);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_8.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_TurnOn_9();
            Relay_TurnOff_11();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnOut_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d5723811-9cd6-4731-807d-7b600b273862", "Toggle", Relay_OnOut_9)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d5723811-9cd6-4731-807d-7b600b273862", "Toggle", Relay_OffOut_9)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d5723811-9cd6-4731-807d-7b600b273862", "Toggle", Relay_ToggleOut_9)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d5723811-9cd6-4731-807d-7b600b273862", "Toggle", Relay_TurnOn_9)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( play_previous != play || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     play_previous = play;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_9.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_9, index + 1);
               }
               logic_uScriptAct_Toggle_Target_9[ index++ ] = play;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_9.TurnOn(logic_uScriptAct_Toggle_Target_9, logic_uScriptAct_Toggle_IgnoreChildren_9);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d5723811-9cd6-4731-807d-7b600b273862", "Toggle", Relay_TurnOff_9)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( play_previous != play || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     play_previous = play;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_9.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_9, index + 1);
               }
               logic_uScriptAct_Toggle_Target_9[ index++ ] = play;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_9.TurnOff(logic_uScriptAct_Toggle_Target_9, logic_uScriptAct_Toggle_IgnoreChildren_9);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d5723811-9cd6-4731-807d-7b600b273862", "Toggle", Relay_Toggle_9)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( play_previous != play || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     play_previous = play;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_9.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_9, index + 1);
               }
               logic_uScriptAct_Toggle_Target_9[ index++ ] = play;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_9.Toggle(logic_uScriptAct_Toggle_Target_9, logic_uScriptAct_Toggle_IgnoreChildren_9);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_10()
   {
      if (true == CheckDebugBreak("7babdd8f-da85-4cfa-a119-3a516eb6fea1", "Global_Update", Relay_OnUpdate_10)) return; 
      Relay_In_8();
   }
   
   void Relay_OnLateUpdate_10()
   {
      if (true == CheckDebugBreak("7babdd8f-da85-4cfa-a119-3a516eb6fea1", "Global_Update", Relay_OnLateUpdate_10)) return; 
   }
   
   void Relay_OnFixedUpdate_10()
   {
      if (true == CheckDebugBreak("7babdd8f-da85-4cfa-a119-3a516eb6fea1", "Global_Update", Relay_OnFixedUpdate_10)) return; 
   }
   
   void Relay_OnOut_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("821deb18-5ea5-4185-b8e1-d95fb4704453", "Toggle", Relay_OnOut_11)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("821deb18-5ea5-4185-b8e1-d95fb4704453", "Toggle", Relay_OffOut_11)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("821deb18-5ea5-4185-b8e1-d95fb4704453", "Toggle", Relay_ToggleOut_11)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("821deb18-5ea5-4185-b8e1-d95fb4704453", "Toggle", Relay_TurnOn_11)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( credit_previous != credit || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     credit_previous = credit;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_11.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_11, index + 1);
               }
               logic_uScriptAct_Toggle_Target_11[ index++ ] = credit;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_11.TurnOn(logic_uScriptAct_Toggle_Target_11, logic_uScriptAct_Toggle_IgnoreChildren_11);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("821deb18-5ea5-4185-b8e1-d95fb4704453", "Toggle", Relay_TurnOff_11)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( credit_previous != credit || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     credit_previous = credit;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_11.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_11, index + 1);
               }
               logic_uScriptAct_Toggle_Target_11[ index++ ] = credit;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_11.TurnOff(logic_uScriptAct_Toggle_Target_11, logic_uScriptAct_Toggle_IgnoreChildren_11);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("821deb18-5ea5-4185-b8e1-d95fb4704453", "Toggle", Relay_Toggle_11)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( credit_previous != credit || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     credit_previous = credit;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_11.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_11, index + 1);
               }
               logic_uScriptAct_Toggle_Target_11[ index++ ] = credit;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_11.Toggle(logic_uScriptAct_Toggle_Target_11, logic_uScriptAct_Toggle_IgnoreChildren_11);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_28()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f8d3200e-dcac-4a0c-bbfa-e00eaa5e11d6", "Input_Events_Filter", Relay_In_28)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_28.In(logic_uScriptAct_OnInputEventFilter_KeyCode_28);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_28.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_35();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("201ece82-9240-4432-9dd2-1406879ab5b0", "Input_Events_Filter", Relay_In_29)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_29.In(logic_uScriptAct_OnInputEventFilter_KeyCode_29);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_29.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_43();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_KeyEvent_30()
   {
      if (true == CheckDebugBreak("e68d9981-6d8a-421a-9a6c-fae41aa20d74", "Input_Events", Relay_KeyEvent_30)) return; 
      Relay_In_28();
   }
   
   void Relay_KeyEvent_32()
   {
      if (true == CheckDebugBreak("48091c20-0b38-433e-9ee5-99bd3e3702c1", "Input_Events", Relay_KeyEvent_32)) return; 
      Relay_In_29();
   }
   
   void Relay_In_35()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("09d02581-a996-40c6-b4eb-8c9a032bc0f6", "Compare_Int", Relay_In_35)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_35 = selectorVar;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_35.In(logic_uScriptCon_CompareInt_A_35, logic_uScriptCon_CompareInt_B_35);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_35.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_38();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_38()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fa22a4d9-f245-4e49-b37d-6167ce3105df", "Set_Int", Relay_In_38)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_38.In(logic_uScriptAct_SetInt_Value_38, out logic_uScriptAct_SetInt_Target_38);
         selectorVar = logic_uScriptAct_SetInt_Target_38;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_41()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bfa5f1fe-7008-4ad3-933d-1228ba9ce38c", "Set_Int", Relay_In_41)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_41.In(logic_uScriptAct_SetInt_Value_41, out logic_uScriptAct_SetInt_Target_41);
         selectorVar = logic_uScriptAct_SetInt_Target_41;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_43()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3ca8e3d4-ee3b-48c9-bab1-e07e81d0d5bf", "Compare_Int", Relay_In_43)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_43 = selectorVar;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_43.In(logic_uScriptCon_CompareInt_A_43, logic_uScriptCon_CompareInt_B_43);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_43.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_41();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "selector.uscript:play", play);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9036281d-c596-4e32-8f30-bd5283aa9f73", play);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "selector.uscript:credit", credit);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "4c0db4c2-f507-496e-8584-fdd4d71ed0ed", credit);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "selector.uscript:selectorVar", selectorVar);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "324d3d2c-1a8f-473e-b3c4-9b03e043ffe2", selectorVar);
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
