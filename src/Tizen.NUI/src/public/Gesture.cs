/*
 * Copyright(c) 2017 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

namespace Tizen.NUI
{

    /// <summary>
    /// Base structure for different gestures that an application can receive.<br />
    /// A Gesture is an event that is produced from a combination of several touch events
    /// in a particular order or within a certain time frame (for example, pinch).<br />
    /// </summary>
    /// <since_tizen> 3 </since_tizen>
    public class Gesture : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        /// <summary>
        /// swigCMemOwn.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected bool swigCMemOwn;

        internal Gesture(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Gesture obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        /// <summary>
        /// A Flat to check if it is already disposed.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected bool disposed = false;

        /// <summary>
        /// Dispose.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        ~Gesture()
        {
            if(!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        /// <summary>
        /// Dispose.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// Dispose.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if(type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_Gesture(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
            disposed = true;
        }


        /// <summary>
        /// The gesture type.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Gesture.GestureType Type
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// The gesture state.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Gesture.StateType State
        {
            get
            {
                return state;
            }
        }

        /// <summary>
        /// The time the gesture took place.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public uint Time
        {
            get
            {
                return time;
            }
        }

        /// <summary>
        /// The Copy constructor.
        /// </summary>
        /// <param name="rhs">A reference to the copied handle</param>
        /// <since_tizen> 3 </since_tizen>
        public Gesture(Gesture rhs) : this(NDalicPINVOKE.new_Gesture(Gesture.getCPtr(rhs)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        private Gesture.GestureType type
        {
            set
            {
                NDalicPINVOKE.Gesture_type_set(swigCPtr, (int)value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                Gesture.GestureType ret = (Gesture.GestureType)NDalicPINVOKE.Gesture_type_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private Gesture.StateType state
        {
            set
            {
                NDalicPINVOKE.Gesture_state_set(swigCPtr, (int)value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                Gesture.StateType ret = (Gesture.StateType)NDalicPINVOKE.Gesture_state_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private uint time
        {
            set
            {
                NDalicPINVOKE.Gesture_time_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                uint ret = NDalicPINVOKE.Gesture_time_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Enumeration for type of gesture.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public enum GestureType
        {
            /// <summary>
            /// When two touch points move away or towards each other.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            Pinch = 1 << 0,
            /// <summary>
            /// When the user drags their finger(s) in a particular direction.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            Pan = 1 << 1,
            /// <summary>
            /// When the user taps the screen.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            Tap = 1 << 2,
            /// <summary>
            ///  When the user continues to touch the same area on the screen for the device configured time.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            LongPress = 1 << 3
        }

        /// <summary>
        /// Enumeration for state of the gesture.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public enum StateType
        {
            /// <summary>
            /// There is no state associated with this gesture.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            Clear,
            /// <summary>
            /// The touched points on the screen have moved enough to be considered a gesture.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            Started,
            /// <summary>
            /// The gesture is continuing.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            Continuing,
            /// <summary>
            /// The user has lifted a finger or touched an additional point on the screen.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            Finished,
            /// <summary>
            /// The gesture has been cancelled.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            Cancelled,
            /// <summary>
            ///  A gesture is possible.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            Possible
        }

    }

}