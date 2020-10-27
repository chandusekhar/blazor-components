﻿using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace Blazor.Components.Common.JsInterop.Scroll
{
	/// <summary>
	/// Injectable service to handle JS document/window 'scroll' events for the whole document.
	/// </summary>
	public interface IScrollHandler : IAsyncDisposable
	{
		/// <summary>
		/// Scrolls the given element into the page view area.
		/// </summary>
		/// <param name="elementReference">Blazor reference to an HTML element</param>
		/// <returns>Async Task</returns>
		Task ScrollToElementAsync(ElementReference elementReference);

		/// <summary>
		/// Scrolls to end of the page (X bottom).
		/// </summary>
		/// <returns>Async Task</returns>
		Task ScrollToPageEndAsync();
		/// <summary>
		/// Scrolls to top of the page (X top).
		/// </summary>
		/// <returns>Async Task</returns>
		Task ScrollToPageTopAsync();
		/// <summary>
		/// Scrolls to X position on the page.
		/// </summary>
		/// <param name="x">Scroll top x value</param>
		/// <returns>Async Task</returns>
		Task ScrollToPageXAsync(double x);
		/// <summary>
		/// Scrolls to Y position on the page.
		/// </summary>
		/// <param name="x">Scroll top x value</param>
		/// <returns>Async Task</returns>
		Task ScrollToPageYAsync(double y);
		/// <summary>
		/// Returns page X scroll position.
		/// </summary>
		/// <returns>Async Task</returns>
		Task<ScrollEventArgs> GetPageScrollPosAsync();

		/// <summary>
		/// Adds event listener for 'scroll' HTML event for the whole document/window.
		/// </summary>
		/// <param name="scrollCallback"></param>
		/// <returns>Async Task with event id to unsubscribe from event</returns>
		Task<string> RegisterPageScrollAsync(Func<ScrollEventArgs, Task> scrollCallback);
		/// <summary>
		/// Removes event listener for 'scroll' HTML event for the whole document/window by the given event Id.
		/// </summary>
		/// <param name="eventId"></param>
		/// <returns>Async Task</returns>
		Task RemovePageScrollAsync(string eventId);
	}
}