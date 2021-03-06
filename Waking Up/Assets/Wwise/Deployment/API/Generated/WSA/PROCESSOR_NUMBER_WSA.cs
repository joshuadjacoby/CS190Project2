#if UNITY_WSA && ! UNITY_EDITOR
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PROCESSOR_NUMBER : IDisposable {
  private IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal PROCESSOR_NUMBER(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(PROCESSOR_NUMBER obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  ~PROCESSOR_NUMBER() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_PROCESSOR_NUMBER(swigCPtr);
        }
        swigCPtr = IntPtr.Zero;
      }
      GC.SuppressFinalize(this);
    }
  }

  public ushort Group {
    set {
      AkSoundEnginePINVOKE.CSharp_PROCESSOR_NUMBER_Group_set(swigCPtr, value);
    } 
    get {
      ushort ret = AkSoundEnginePINVOKE.CSharp_PROCESSOR_NUMBER_Group_get(swigCPtr);
      return ret;
    } 
  }

  public byte Number {
    set {
      AkSoundEnginePINVOKE.CSharp_PROCESSOR_NUMBER_Number_set(swigCPtr, value);
    } 
    get {
      byte ret = AkSoundEnginePINVOKE.CSharp_PROCESSOR_NUMBER_Number_get(swigCPtr);
      return ret;
    } 
  }

  public byte Reserved {
    set {
      AkSoundEnginePINVOKE.CSharp_PROCESSOR_NUMBER_Reserved_set(swigCPtr, value);
    } 
    get {
      byte ret = AkSoundEnginePINVOKE.CSharp_PROCESSOR_NUMBER_Reserved_get(swigCPtr);
      return ret;
    } 
  }

  public PROCESSOR_NUMBER() : this(AkSoundEnginePINVOKE.CSharp_new_PROCESSOR_NUMBER(), true) {

  }

}
#endif // #if UNITY_WSA && ! UNITY_EDITOR