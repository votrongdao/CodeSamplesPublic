/**
 * Copyright (C) 2005-2013 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furn
 * 
 * ished to do so, subject to
 * the following conditions:                                            
 *                                                                      
 * The above copyright notice and this permission notice shall be       
 * included in all copies or substantial portions of the Software.      
 *                                                                      
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,      
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF   
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR    
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.                                      
 */
// Marks the right margin of code *******************************************************************

//--------------------------------------
//  Imports
//--------------------------------------
using UnityEngine;

//--------------------------------------
//  Namespace
//--------------------------------------
namespace com.rmc.projects.utilities
{
	
	//--------------------------------------
	//  Namespace Properties
	//--------------------------------------

	//--------------------------------------
	//  Class Attributes
	//--------------------------------------
	
	
	//--------------------------------------
	//  Class
	//--------------------------------------
	/// <summary>
	/// If you want to smoothly move from current value to target value (and back to a reset value)
	/// then this is a great class. Currently works for float only.
	/// </summary>
	public class LerpTarget
	{
		
		//--------------------------------------
		//  Properties
		//--------------------------------------
		// GETTER / SETTER
		
		// PUBLIC
		/// <summary>
		/// The _current_float.
		/// </summary>
		private float _current_float = 8;
		public float current {
			get{
				return _current_float;
			}
			set{
				_current_float = value;
				_doForceTargetValueWithinLimits();
			}
		}


		/// <summary>
		/// The _minimum_float.
		/// </summary>
		private float _minimum_float;
		public float minimum {
			get{
				return _minimum_float;
			}
			set{
				_minimum_float = value;
				_doForceTargetValueWithinLimits();
			}
		}

		/// <summary>
		/// The _maximum_float.
		/// </summary>
		private float _maximum_float;
		public float maximum {
			get{
				return _maximum_float;
			}
			set{
				_maximum_float = value;
				_doForceTargetValueWithinLimits();
			}
		}


		/// <summary>
		/// The _target value_float.
		/// </summary>
		private float _targetValue_float;
		public float targetValue {
			get{
				return _targetValue_float;
			}
			set{
				_targetValue_float = value;
				_doForceTargetValueWithinLimits();
			}
		}

		/// <summary>
		/// The acceleration.
		/// </summary>
		public float acceleration;
		
		// PUBLIC STATIC
		
		// PRIVATE
		
		// PRIVATE STATIC
		
		//--------------------------------------
		//  Methods
		//--------------------------------------
		
		
		///////////////////////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////
		///			CONSTRUCTOR / DESTRUCTOR
		///////////////////////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////
		///<summary>
		///	 Constructor
		///</summary>
		public LerpTarget (float aCurrent_float, float aTarget_float, float aMinimum_float, float aMaximum_float, float aAcceleration_float)
		{
			current 		= aCurrent_float;
			targetValue 	= aTarget_float;
			minimum			= aMinimum_float;
			maximum			= aMaximum_float;
			acceleration  	= aAcceleration_float;
			
		}
		
		~LerpTarget()
		{
			
		}
		
		// PUBLIC
		/// <summary>
		/// Lerps the current to target.
		/// </summary>
		/// <param name="deltaTime">Delta time.</param>
		public void lerpCurrentToTarget (float aDeltaTime_float)
		{
			_lerpCurrentTo (targetValue, aDeltaTime_float);

		}

		// PRIVATE
		/// <summary>
		/// _lerps the current to.
		/// </summary>
		/// <param name="aDeltaTime_float">A delta time_float.</param>
		/// <param name="aNextValue">A next value.</param>
		private void _lerpCurrentTo ( float aNextValue, float aDeltaTime_float)
		{
			//UPDATE
			current =  Mathf.Lerp	(
										current,
										aNextValue,
										aDeltaTime_float*acceleration
									);


		}

		/// <summary>
		/// _dos the force current value within limits.
		/// </summary>
		private void _doForceTargetValueWithinLimits()
		{

			//DIRECTLY AFFECT THE PRIVATE VARIABLE HERE (OTHERWISE INFINITE LOOP)
			if (isDebugging_boolean) {
				//Debug.Log ("keep: " + _targetValue_float + " in ( "+minimum+" & "+maximum+" )");
			}

			_targetValue_float = Mathf.Clamp (_targetValue_float, minimum, maximum); 

		}


		//TODO: REMOVE THIS VARIABLE
		public bool isDebugging_boolean = false;




		// PRIVATE STATIC
		
		// PRIVATE COROUTINE
		
		// PRIVATE INVOKE
		
		//--------------------------------------
		//  Events
		//--------------------------------------







	}
}
