global using System.Collections.Immutable;

global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Localization;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;

global using UnoApp2.Models;
global using UnoApp2.Presentation;
global using UnoApp2.DataContracts;
global using UnoApp2.DataContracts.Serialization;
global using UnoApp2.Services.Caching;
global using UnoApp2.Services.Endpoints;

#if MAUI_EMBEDDING
global using UnoApp2.MauiControls;
#endif
global using ApplicationExecutionState = Windows.ApplicationModel.Activation.ApplicationExecutionState;

global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
