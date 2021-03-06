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

public class MouseEventArgs : InputEventArgs {
  private HandleRef swigCPtr;

  internal MouseEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MouseEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MouseEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_MouseEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal static new void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    MouseEventHandler handler_ = (MouseEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new MouseEventArgs(args, false));
    }
  }

  public MouseButtonState LeftButton {
    get {
      MouseButtonState ret = (MouseButtonState)NoesisGUI_PINVOKE.MouseEventArgs_LeftButton_get(swigCPtr);
      return ret;
    } 
  }

  public MouseButtonState MiddleButton {
    get {
      MouseButtonState ret = (MouseButtonState)NoesisGUI_PINVOKE.MouseEventArgs_MiddleButton_get(swigCPtr);
      return ret;
    } 
  }

  public MouseButtonState RightButton {
    get {
      MouseButtonState ret = (MouseButtonState)NoesisGUI_PINVOKE.MouseEventArgs_RightButton_get(swigCPtr);
      return ret;
    } 
  }

  public MouseButtonState XButton1 {
    get {
      MouseButtonState ret = (MouseButtonState)NoesisGUI_PINVOKE.MouseEventArgs_XButton1_get(swigCPtr);
      return ret;
    } 
  }

  public MouseButtonState XButton2 {
    get {
      MouseButtonState ret = (MouseButtonState)NoesisGUI_PINVOKE.MouseEventArgs_XButton2_get(swigCPtr);
      return ret;
    } 
  }

  public MouseEventArgs(object s, RoutedEvent e) : this(NoesisGUI_PINVOKE.new_MouseEventArgs(Noesis.Extend.GetInstanceHandle(s), RoutedEvent.getCPtr(e)), true) {
  }

  public Point GetPosition(UIElement relativeTo) {
    IntPtr ret = NoesisGUI_PINVOKE.MouseEventArgs_GetPosition(swigCPtr, UIElement.getCPtr(relativeTo));
    if (ret != IntPtr.Zero) {
      return Marshal.PtrToStructure<Point>(ret);
    }
    else {
      return new Point();
    }
  }

}

}

