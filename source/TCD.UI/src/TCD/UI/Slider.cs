/***************************************************************************************************
 * FileName:             Slider.cs
 * Date:                 20181001
 * Copyright:            Copyright © 2017-2019 Thomas Corwin, et al. All Rights Reserved.
 * License:              https://github.com/tom-corwin/tcdfx/blob/master/LICENSE.md
 **************************************************************************************************/

using System;
using TCD.InteropServices;
using TCD.Native;
using TCD.UI.SafeHandles;

namespace TCD.UI
{
    /// <summary>
    /// Represents a control that inputs a linear value.
    /// </summary>
    public class Slider : Control
    {
        private int value = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Slider"/> class with the specified minimum and maximum values.
        /// </summary>
        /// <param name="min">The minimum this <see cref="Slider"/> object's value can be.</param>
        /// <param name="max">The maximum this <see cref="Slider"/> object's value can be.</param>
        public Slider(int min = 0, int max = 100) : base(new SafeControlHandle(Libui.Call<Libui.uiNewSlider>()(min, max)))
        {
            MinimumValue = min;
            MaximumValue = max;
            InitializeEvents();
        }

        /// <summary>
        /// Occurs when the <see cref="Value"/> property is changed.
        /// </summary>
        public event EventHandler ValueChanged;

        /// <summary>
        /// Gets this <see cref="Slider"/> object's minimum value.
        /// </summary>
        public int MinimumValue { get; }

        /// <summary>
        /// Gets this <see cref="Slider"/> object's maximum value.
        /// </summary>
        public int MaximumValue { get; }

        /// <summary>
        /// Gets or sets the current value of this <see cref="Slider"/>.
        /// </summary>
        public int Value
        {
            get
            {
                if (IsInvalid) throw new InvalidHandleException();
                value = Libui.Call<Libui.uiSliderValue>()(Handle);
                return value;
            }
            set
            {
                if (this.value == value) return;
                if (IsInvalid) throw new InvalidHandleException();
                Libui.Call<Libui.uiSliderSetValue>()(Handle, value);
                this.value = value;
            }
        }

        /// <summary>
        /// Called when the <see cref="ValueChanged"/> event is raised.
        /// </summary>
        protected virtual void OnValueChanged(Slider sender, EventArgs e) => ValueChanged?.Invoke(sender, e);

        /// <summary>
        /// Initializes this <see cref="Slider"/> object's events.
        /// </summary>
        protected sealed override void InitializeEvents()
        {
            if (IsInvalid) throw new InvalidHandleException();
            Libui.Call<Libui.uiSliderOnChanged>()(Handle, (slider, data) => OnValueChanged(this, EventArgs.Empty), IntPtr.Zero);
        }
    }
}