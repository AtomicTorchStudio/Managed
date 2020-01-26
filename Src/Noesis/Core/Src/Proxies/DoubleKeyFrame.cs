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

namespace Noesis
{

public class DoubleKeyFrame : Freezable {
  internal new static DoubleKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new DoubleKeyFrame(cPtr, cMemoryOwn);
  }

  internal DoubleKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(DoubleKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected DoubleKeyFrame() {
  }

  public static DependencyProperty KeyTimeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DoubleKeyFrame_KeyTimeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ValueProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DoubleKeyFrame_ValueProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public KeyTime KeyTime {
    set {
      NoesisGUI_PINVOKE.DoubleKeyFrame_KeyTime_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.DoubleKeyFrame_KeyTime_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<KeyTime>(ret);
      }
      else {
        return new KeyTime();
      }
    }

  }

  public double Value {
    set {
      NoesisGUI_PINVOKE.DoubleKeyFrame_Value_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.DoubleKeyFrame_Value_get(swigCPtr);
      return ret;
    } 
  }

}

}

