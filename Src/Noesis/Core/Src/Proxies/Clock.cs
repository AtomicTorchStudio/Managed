//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Noesis
{

public class Clock : BaseComponent {
  internal new static Clock CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Clock(cPtr, cMemoryOwn);
  }

  internal Clock(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Clock obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected Clock() {
  }

  #region Events
  #region Completed
  public delegate void CompletedHandler(object sender, NoesisEventArgs e);
  public event CompletedHandler Completed {
    add {
      if (!_Completed.ContainsKey(swigCPtr.Handle)) {
        _Completed.Add(swigCPtr.Handle, null);

        NoesisGUI_PINVOKE.BindEvent_Clock_Completed(_raiseCompleted, swigCPtr.Handle);
      }

      _Completed[swigCPtr.Handle] += value;
    }
    remove {
      if (_Completed.ContainsKey(swigCPtr.Handle)) {

        _Completed[swigCPtr.Handle] -= value;

        if (_Completed[swigCPtr.Handle] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_Clock_Completed(_raiseCompleted, swigCPtr.Handle);

          _Completed.Remove(swigCPtr.Handle);
        }
      }
    }
  }

  internal delegate void RaiseCompletedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseCompletedCallback _raiseCompleted = RaiseCompleted;

  [MonoPInvokeCallback(typeof(RaiseCompletedCallback))]
  private static void RaiseCompleted(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (Noesis.Extend.Initialized) {
        if (sender == IntPtr.Zero && e == IntPtr.Zero) {
          _Completed.Remove(cPtr);
          return;
        }
        CompletedHandler handler = null;
        if (!_Completed.TryGetValue(cPtr, out handler)) {
          throw new InvalidOperationException("Delegate not registered for Completed event");
        }
        if (handler != null) {
          handler(Noesis.Extend.GetProxy(sender, false), new NoesisEventArgs(e, false));
        }
      }
    }
    catch (Exception exception) {
      Noesis.Error.UnhandledException(exception);
    }
  }

  internal static Dictionary<IntPtr, CompletedHandler> _Completed =
      new Dictionary<IntPtr, CompletedHandler>();
  #endregion

  #endregion

  public int CurrentIteration {
    get {
      int ret = NoesisGUI_PINVOKE.Clock_CurrentIteration_get(swigCPtr);
      return ret;
    } 
  }

  public float CurrentProgress {
    get {
      float ret = NoesisGUI_PINVOKE.Clock_CurrentProgress_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrentTime {
    get {
      double ret = NoesisGUI_PINVOKE.Clock_CurrentTime_get(swigCPtr);
      return ret;
    } 
  }

  public ClockState CurrentState {
    get {
      ClockState ret = (ClockState)NoesisGUI_PINVOKE.Clock_CurrentState_get(swigCPtr);
      return ret;
    } 
  }

  public bool HasControllableRoot {
    get {
      bool ret = NoesisGUI_PINVOKE.Clock_HasControllableRoot_get(swigCPtr);
      return ret;
    } 
  }

  public ClockGroup Parent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Clock_Parent_get(swigCPtr);
      return (ClockGroup)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Timeline Timeline {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Clock_Timeline_get(swigCPtr);
      return (Timeline)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Clock_GetStaticType();
    return ret;
  }

}

}

