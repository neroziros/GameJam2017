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
   public System.Single axis = (float) 0;
   public System.Single axis2 = (float) 0;
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
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_17 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_17 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_17 = (int) 2;
   bool logic_uScriptCon_CompareInt_GreaterThan_17 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_17 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_17 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_17 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_17 = true;
   bool logic_uScriptCon_CompareInt_LessThan_17 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_18 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_18 = (int) 1;
   System.Int32 logic_uScriptAct_SetInt_Target_18;
   bool logic_uScriptAct_SetInt_Out_18 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_19 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_19 = (int) 2;
   System.Int32 logic_uScriptAct_SetInt_Target_19;
   bool logic_uScriptAct_SetInt_Out_19 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_21 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_21 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_21 = (int) 1;
   bool logic_uScriptCon_CompareInt_GreaterThan_21 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_21 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_21 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_21 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_21 = true;
   bool logic_uScriptCon_CompareInt_LessThan_21 = true;
   //pointer to script instanced logic node
   uScriptAct_GetAxis logic_uScriptAct_GetAxis_uScriptAct_GetAxis_22 = new uScriptAct_GetAxis( );
   System.String logic_uScriptAct_GetAxis_axisName_22 = "Vertical 1";
   System.Single logic_uScriptAct_GetAxis_result_22;
   System.Single logic_uScriptAct_GetAxis_rawResult_22;
   bool logic_uScriptAct_GetAxis_Out_22 = true;
   //pointer to script instanced logic node
   uScriptAct_GetAxis logic_uScriptAct_GetAxis_uScriptAct_GetAxis_24 = new uScriptAct_GetAxis( );
   System.String logic_uScriptAct_GetAxis_axisName_24 = "Vertical 1";
   System.Single logic_uScriptAct_GetAxis_result_24;
   System.Single logic_uScriptAct_GetAxis_rawResult_24;
   bool logic_uScriptAct_GetAxis_Out_24 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_26 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_26 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_26 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_26 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_26 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_26 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_26 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_26 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_26 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_27 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_27 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_27 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_27 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_27 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_27 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_27 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_27 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_27 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_31 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_31 = UnityEngine.KeyCode.JoystickButton1;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_31 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_31 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_31 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_33 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_33 = (int) 2;
   System.Int32 logic_uScriptCon_CompareInt_B_33 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_33 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_33 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_33 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_33 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_33 = true;
   bool logic_uScriptCon_CompareInt_LessThan_33 = true;
   //pointer to script instanced logic node
   public uScriptAct_LoadLevel load = new uScriptAct_LoadLevel( );
   System.String logic_uScriptAct_LoadLevel_name_34 = "Game";
   System.Boolean logic_uScriptAct_LoadLevel_destroyOtherObjects_34 = (bool) true;
   System.Boolean logic_uScriptAct_LoadLevel_blockUntilLoaded_34 = (bool) true;
   bool logic_uScriptAct_LoadLevel_Out_34 = true;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_35 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_35 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_35 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_35 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_35 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_35 = false;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_10 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_28 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_29 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_30 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
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
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( credit_previous != credit || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         credit_previous = credit;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( play_previous != play || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         play_previous = play;
         
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
      if ( null == event_UnityEngine_GameObject_Instance_28 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_28 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_28 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_28.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_28.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_28;
                  component.OnLateUpdate += Instance_OnLateUpdate_28;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_28;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_29 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_29 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_29 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_29.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_29.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_29;
                  component.OnLateUpdate += Instance_OnLateUpdate_29;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_29;
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
      if ( null != event_UnityEngine_GameObject_Instance_28 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_28.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_28;
               component.OnLateUpdate -= Instance_OnLateUpdate_28;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_28;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_29 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_29.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_29;
               component.OnLateUpdate -= Instance_OnLateUpdate_29;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_29;
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
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_17.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_18.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_19.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_21.SetParent(g);
      logic_uScriptAct_GetAxis_uScriptAct_GetAxis_22.SetParent(g);
      logic_uScriptAct_GetAxis_uScriptAct_GetAxis_24.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_26.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_27.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_31.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_33.SetParent(g);
      load.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_35.SetParent(g);
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
      load.Loaded += uScriptAct_LoadLevel_Loaded_34;
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
      
      load.Update( );
      if (true == logic_uScriptAct_Destroy_WaitOneTick_35)
      {
         Relay_WaitOneTick_35();
      }
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
      load.Loaded -= uScriptAct_LoadLevel_Loaded_34;
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
   
   void Instance_OnUpdate_28(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_28( );
   }
   
   void Instance_OnLateUpdate_28(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_28( );
   }
   
   void Instance_OnFixedUpdate_28(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_28( );
   }
   
   void Instance_OnUpdate_29(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_29( );
   }
   
   void Instance_OnLateUpdate_29(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_29( );
   }
   
   void Instance_OnFixedUpdate_29(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_29( );
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
   
   void uScriptAct_LoadLevel_Loaded_34(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Loaded_34( );
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
   
   void Relay_In_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("09d02581-a996-40c6-b4eb-8c9a032bc0f6", "Compare_Int", Relay_In_17)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_17 = selectorVar;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_17.In(logic_uScriptCon_CompareInt_A_17, logic_uScriptCon_CompareInt_B_17);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_17.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_18();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fa22a4d9-f245-4e49-b37d-6167ce3105df", "Set_Int", Relay_In_18)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_18.In(logic_uScriptAct_SetInt_Value_18, out logic_uScriptAct_SetInt_Target_18);
         selectorVar = logic_uScriptAct_SetInt_Target_18;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_19()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bfa5f1fe-7008-4ad3-933d-1228ba9ce38c", "Set_Int", Relay_In_19)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_19.In(logic_uScriptAct_SetInt_Value_19, out logic_uScriptAct_SetInt_Target_19);
         selectorVar = logic_uScriptAct_SetInt_Target_19;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3ca8e3d4-ee3b-48c9-bab1-e07e81d0d5bf", "Compare_Int", Relay_In_21)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_21 = selectorVar;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_21.In(logic_uScriptCon_CompareInt_A_21, logic_uScriptCon_CompareInt_B_21);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_21.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_19();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_22()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("08eb620e-f963-49fb-aff8-cac91caf025a", "Get_Axis", Relay_In_22)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetAxis_uScriptAct_GetAxis_22.In(logic_uScriptAct_GetAxis_axisName_22, out logic_uScriptAct_GetAxis_result_22, out logic_uScriptAct_GetAxis_rawResult_22);
         axis = logic_uScriptAct_GetAxis_result_22;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetAxis_uScriptAct_GetAxis_22.Out;
         
         if ( test_0 == true )
         {
            Relay_In_27();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Get Axis.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_24()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("03a09ab8-5aed-426f-ab5a-02c2b5a7d471", "Get_Axis", Relay_In_24)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetAxis_uScriptAct_GetAxis_24.In(logic_uScriptAct_GetAxis_axisName_24, out logic_uScriptAct_GetAxis_result_24, out logic_uScriptAct_GetAxis_rawResult_24);
         axis2 = logic_uScriptAct_GetAxis_result_24;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetAxis_uScriptAct_GetAxis_24.Out;
         
         if ( test_0 == true )
         {
            Relay_In_26();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Get Axis.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_26()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9312ec8a-38c3-4cc9-b76e-19e1b201233f", "Compare_Float", Relay_In_26)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_26 = axis2;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_26.In(logic_uScriptCon_CompareFloat_A_26, logic_uScriptCon_CompareFloat_B_26);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_26.GreaterThan;
         
         if ( test_0 == true )
         {
            Relay_In_21();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_27()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("11ddfa13-4ceb-4dbf-aae2-a10394f98df9", "Compare_Float", Relay_In_27)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_27 = axis;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_27.In(logic_uScriptCon_CompareFloat_A_27, logic_uScriptCon_CompareFloat_B_27);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_27.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_17();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_28()
   {
      if (true == CheckDebugBreak("1cb20517-5a34-42ee-856c-a0c92381c0cf", "Global_Update", Relay_OnUpdate_28)) return; 
      Relay_In_22();
   }
   
   void Relay_OnLateUpdate_28()
   {
      if (true == CheckDebugBreak("1cb20517-5a34-42ee-856c-a0c92381c0cf", "Global_Update", Relay_OnLateUpdate_28)) return; 
   }
   
   void Relay_OnFixedUpdate_28()
   {
      if (true == CheckDebugBreak("1cb20517-5a34-42ee-856c-a0c92381c0cf", "Global_Update", Relay_OnFixedUpdate_28)) return; 
   }
   
   void Relay_OnUpdate_29()
   {
      if (true == CheckDebugBreak("52280efc-fc5c-48c0-a1ed-879af7632eeb", "Global_Update", Relay_OnUpdate_29)) return; 
      Relay_In_24();
   }
   
   void Relay_OnLateUpdate_29()
   {
      if (true == CheckDebugBreak("52280efc-fc5c-48c0-a1ed-879af7632eeb", "Global_Update", Relay_OnLateUpdate_29)) return; 
   }
   
   void Relay_OnFixedUpdate_29()
   {
      if (true == CheckDebugBreak("52280efc-fc5c-48c0-a1ed-879af7632eeb", "Global_Update", Relay_OnFixedUpdate_29)) return; 
   }
   
   void Relay_KeyEvent_30()
   {
      if (true == CheckDebugBreak("66433aa8-5763-4943-b4d3-8282c58b37f0", "Input_Events", Relay_KeyEvent_30)) return; 
      Relay_In_31();
   }
   
   void Relay_In_31()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("87c1cce4-90b1-40e3-8200-3427af6855a2", "Input_Events_Filter", Relay_In_31)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_31.In(logic_uScriptAct_OnInputEventFilter_KeyCode_31);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_31.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_33();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_33()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1d2cad76-c3f2-4c8d-9f70-1cdbd3eafb0f", "Compare_Int", Relay_In_33)) return; 
         {
            {
            }
            {
               logic_uScriptCon_CompareInt_B_33 = selectorVar;
               
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_33.In(logic_uScriptCon_CompareInt_A_33, logic_uScriptCon_CompareInt_B_33);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_33.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_34();
            Relay_In_35();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Loaded_34()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fae72615-f1ab-4726-a9eb-b955bf529578", "Load_Level", Relay_Loaded_34)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Load Level.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_34()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fae72615-f1ab-4726-a9eb-b955bf529578", "Load_Level", Relay_In_34)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         load.In(logic_uScriptAct_LoadLevel_name_34, logic_uScriptAct_LoadLevel_destroyOtherObjects_34, logic_uScriptAct_LoadLevel_blockUntilLoaded_34);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Load Level.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_35()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bd90408d-595f-4488-87f6-f91fe6cb2daa", "Destroy", Relay_In_35)) return; 
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
               if ( logic_uScriptAct_Destroy_Target_35.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_35, index + 1);
               }
               logic_uScriptAct_Destroy_Target_35[ index++ ] = play;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_uScriptAct_Destroy_35.In(logic_uScriptAct_Destroy_Target_35, logic_uScriptAct_Destroy_DelayTime_35);
         logic_uScriptAct_Destroy_WaitOneTick_35 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_WaitOneTick_35( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
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
               if ( logic_uScriptAct_Destroy_Target_35.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_35, index + 1);
               }
               logic_uScriptAct_Destroy_Target_35[ index++ ] = play;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_WaitOneTick_35 = logic_uScriptAct_Destroy_uScriptAct_Destroy_35.WaitOneTick();
         if ( true == logic_uScriptAct_Destroy_WaitOneTick_35 )
         {
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript selector.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "selector.uscript:credit", credit);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "4c0db4c2-f507-496e-8584-fdd4d71ed0ed", credit);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "selector.uscript:axis", axis);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3e1f6fc4-5054-49e1-83a7-981a509b4515", axis);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "selector.uscript:axis2", axis2);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cb811044-40c8-486d-a5de-9501cb6a7261", axis2);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "selector.uscript:selectorVar", selectorVar);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f80df78f-def3-4e5e-90e4-a4e3ce0c680a", selectorVar);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "selector.uscript:play", play);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "2cd2dfa3-6b98-43d8-8860-393f4d93a6ab", play);
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