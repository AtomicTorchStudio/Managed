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

public class ListBoxItem : ContentControl {
  internal new static ListBoxItem CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ListBoxItem(cPtr, cMemoryOwn);
  }

  internal ListBoxItem(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ListBoxItem obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events
  public event RoutedEventHandler Selected {
    add {
      AddHandler(SelectedEvent, value);
    }
    remove {
      RemoveHandler(SelectedEvent, value);
    }
  }

  public event RoutedEventHandler Unselected {
    add {
      AddHandler(UnselectedEvent, value);
    }
    remove {
      RemoveHandler(UnselectedEvent, value);
    }
  }

  #endregion

  public ListBoxItem() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(ListBoxItem)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ListBoxItem();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty IsSelectedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ListBoxItem_IsSelectedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent SelectedEvent {
    set {
      NoesisGUI_PINVOKE.ListBoxItem_SelectedEvent_set(RoutedEvent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ListBoxItem_SelectedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent UnselectedEvent {
    set {
      NoesisGUI_PINVOKE.ListBoxItem_UnselectedEvent_set(RoutedEvent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ListBoxItem_UnselectedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsSelected {
    set {
      NoesisGUI_PINVOKE.ListBoxItem_IsSelected_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ListBoxItem_IsSelected_get(swigCPtr);
      return ret;
    } 
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ListBoxItem(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

