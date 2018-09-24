using System;


namespace VendasWEBMVC1.Models.ViewModels {
    public class ErrorViewModel {

        public string RequestId { get; set; }

        public string Message { get; set; } //para mensagens de erro personalizadas

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}