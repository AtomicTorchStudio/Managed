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

public class Timeline : Animatable {
  internal new static Timeline CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Timeline(cPtr, cMemoryOwn);
  }

  internal Timeline(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Timeline obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected Timeline() {
  }

  #region Events
  #region Completed
  public delegate void CompletedHandler(object sender, System.EventArgs e);
  public event CompletedHandler Completed {
    add {
      if (!_Completed.ContainsKey(swigCPtr.Handle)) {
        _Completed.Add(swigCPtr.Handle, null);

        NoesisGUI_PINVOKE.BindEvent_Timeline_Completed(_raiseCompleted, swigCPtr.Handle);
      }

      _Completed[swigCPtr.Handle] += value;
    }
    remove {
      if (_Completed.ContainsKey(swigCPtr.Handle)) {

        _Completed[swigCPtr.Handle] -= value;

        if (_Completed[swigCPtr.Handle] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_Timeline_Completed(_raiseCompleted, swigCPtr.Handle);

          _Completed.Remove(swigCPtr.Handle);
        }
      }
    }
  }

  internal delegate void RaiseCompletedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseCompletedCallback _raiseCompleted = RaiseCompleted;

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TimelineEventArgs {
        IntPtr target;

        public DependencyObject Target {
            get {
                return (DependencyObject)Noesis.Extend.GetProxy(target, false);
            }
        }
    }

    [MonoPInvokeCallback(typeof(RaiseCompletedCallback))]
    private static void RaiseCompleted(IntPtr cPtr, IntPtr sender, IntPtr e) {
        try {
            if (!_Completed.ContainsKey(cPtr)) {
                throw new InvalidOperationException("Delegate not registered for Completed event");
            }
            if (sender == IntPtr.Zero && e == IntPtr.Zero) {
                _Completed.Remove(cPtr);
                return;
            }
            if (Noesis.Extend.Initialized) {
                CompletedHandler handler = _Completed[cPtr];
                if (handler == null)
                {
                    return;
                }

                var args = Marshal.PtrToStructure<TimelineEventArgs>(e);
	      
                foreach (var @delegate in handler.GetInvocationList())
                {
                    var storyboardTarget = args.Target as FrameworkElement;
                    if (storyboardTarget.Tag is FrameworkElement)
                    {
                        // special hack found!
                        @delegate.DynamicInvoke(Noesis.Extend.GetProxy(sender, false), new System.EventArgs());
                        return;
                    }

                    var delegateTarget = @delegate.Target;

                    while (storyboardTarget != null)
                    {
                        if (ReferenceEquals(storyboardTarget, delegateTarget))
                        {
                            @delegate.DynamicInvoke(Noesis.Extend.GetProxy(sender, false), new System.EventArgs());
                            break;
                        }
                        storyboardTarget = VisualTreeHelper.GetParent(storyboardTarget) as FrameworkElement;
                    }
                }
            }
        }
        catch (Exception exception) {
            Noesis.Error.UnhandledException(exception);
        }
    }


  static Dictionary<IntPtr, CompletedHandler> _Completed =
      new Dictionary<IntPtr, CompletedHandler>();
  #endregion

  #endregion

  public static int GetDesiredFrameRate(DependencyObject timeline) {
    int ret = NoesisGUI_PINVOKE.Timeline_GetDesiredFrameRate(DependencyObject.getCPtr(timeline));
    return ret;
  }

  public static void SetDesiredFrameRate(DependencyObject timeline, int rate) {
    NoesisGUI_PINVOKE.Timeline_SetDesiredFrameRate(DependencyObject.getCPtr(timeline), rate);
  }

  public static DependencyProperty AccelerationRatioProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_AccelerationRatioProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty AutoReverseProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_AutoReverseProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty BeginTimeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_BeginTimeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty DecelerationRatioProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_DecelerationRatioProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty DesiredFrameRateProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_DesiredFrameRateProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty DurationProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_DurationProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FillBehaviorProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_FillBehaviorProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty NameProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_NameProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty RepeatBehaviorProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_RepeatBehaviorProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SpeedRatioProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Timeline_SpeedRatioProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public double AccelerationRatio {
    set {
      NoesisGUI_PINVOKE.Timeline_AccelerationRatio_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Timeline_AccelerationRatio_get(swigCPtr);
      return ret;
    } 
  }

  public bool AutoReverse {
    set {
      NoesisGUI_PINVOKE.Timeline_AutoReverse_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Timeline_AutoReverse_get(swigCPtr);
      return ret;
    } 
  }

  public Nullable<TimeSpan> BeginTime {
    set {
      NullableTimeSpan tempvalue = value;
      NoesisGUI_PINVOKE.Timeline_BeginTime_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Timeline_BeginTime_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullableTimeSpan>(ret);
      }
      else {
        return new Nullable<TimeSpan>();
      }
    }

  }

  public double DecelerationRatio {
    set {
      NoesisGUI_PINVOKE.Timeline_DecelerationRatio_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Timeline_DecelerationRatio_get(swigCPtr);
      return ret;
    } 
  }

  public Duration Duration {
    set {
      NoesisGUI_PINVOKE.Timeline_Duration_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Timeline_Duration_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Duration>(ret);
      }
      else {
        return new Duration();
      }
    }

  }

  public FillBehavior FillBehavior {
    set {
      NoesisGUI_PINVOKE.Timeline_FillBehavior_set(swigCPtr, (int)value);
    } 
    get {
      FillBehavior ret = (FillBehavior)NoesisGUI_PINVOKE.Timeline_FillBehavior_get(swigCPtr);
      return ret;
    } 
  }

  public string Name {
    set {
      NoesisGUI_PINVOKE.Timeline_Name_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.Timeline_Name_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public RepeatBehavior RepeatBehavior {
    set {
      NoesisGUI_PINVOKE.Timeline_RepeatBehavior_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Timeline_RepeatBehavior_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<RepeatBehavior>(ret);
      }
      else {
        return new RepeatBehavior();
      }
    }

  }

  public double SpeedRatio {
    set {
      NoesisGUI_PINVOKE.Timeline_SpeedRatio_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Timeline_SpeedRatio_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Timeline_GetStaticType();
    return ret;
  }

}

}

