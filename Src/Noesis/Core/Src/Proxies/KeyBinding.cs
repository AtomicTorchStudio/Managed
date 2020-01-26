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
using System.Windows.Input;

namespace Noesis
{

public class KeyBinding : InputBinding {
  internal new static KeyBinding CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new KeyBinding(cPtr, cMemoryOwn);
  }

  internal KeyBinding(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(KeyBinding obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public KeyBinding(ICommand command, KeyGesture gesture)
    : this(CreateKeyBinding(command, gesture), true) {
  }

  public KeyBinding(ICommand command, Key key, ModifierKeys modifiers)
    : this(CreateKeyBinding(command, new KeyGesture(key, modifiers)), true) {
  }

  public KeyBinding() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_KeyBinding();
  }

  public static DependencyProperty KeyProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.KeyBinding_KeyProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ModifiersProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.KeyBinding_ModifiersProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Key Key {
    set {
      NoesisGUI_PINVOKE.KeyBinding_Key_set(swigCPtr, (int)value);
    } 
    get {
      Key ret = (Key)NoesisGUI_PINVOKE.KeyBinding_Key_get(swigCPtr);
      return ret;
    } 
  }

  public ModifierKeys Modifiers {
    set {
      NoesisGUI_PINVOKE.KeyBinding_Modifiers_set(swigCPtr, (int)value);
    } 
    get {
      ModifierKeys ret = (ModifierKeys)NoesisGUI_PINVOKE.KeyBinding_Modifiers_get(swigCPtr);
      return ret;
    } 
  }

  private static IntPtr CreateKeyBinding(object command, KeyGesture gesture) {
    IntPtr ret = NoesisGUI_PINVOKE.KeyBinding_CreateKeyBinding(Noesis.Extend.GetInstanceHandle(command), KeyGesture.getCPtr(gesture));
    return ret;
  }

}

}

