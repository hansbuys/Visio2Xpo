﻿using System;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using cvo.buyshans.Visio2Xpo.UI.Messages;

namespace cvo.buyshans.Visio2Xpo.UI.ViewModels
{
    [Export]
    public class DisplayViewModel : PropertyChangedBase, IHandle<LoadMessage>, IHandle<SaveMessage>
    {
        private readonly IEventAggregator _EventAggregator;
        private String _LabelText;

        [ImportingConstructor]
        public DisplayViewModel(IEventAggregator eventAggregator)
        {
            _EventAggregator = eventAggregator;
            _EventAggregator.Subscribe(this);
        }

        public String LabelText
        {
            get
            {
                return _LabelText;
            }
            set
            {
                if (_LabelText == value) return;
                _LabelText = value;
                NotifyOfPropertyChange();
            }
        }

        #region "Handles"
        public void Handle(LoadMessage message)
        {
            LabelText = "Loaded!";
        }

        public void Handle(SaveMessage message)
        {
            LabelText = "Saved!";
        }
        #endregion "Handles"
    }
}