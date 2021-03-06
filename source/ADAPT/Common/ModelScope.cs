﻿/*******************************************************************************
  * Copyright (C) 2015-16 AgGateway and ADAPT Contributors
  * Copyright (C) 2016 Ag Connections
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Stuart Rhea - initial API and implementation
  *    Joseph Ross - Adding intializer for id
  *******************************************************************************/

namespace AgGateway.ADAPT.ApplicationDataModel.Common
{
    /// <summary>
    /// Enumeration describing the available model sources whose members can use ContextItems. </summary>
    public enum ModelScopeTypeEnum
    {
        ISO11783 = 0,
        ADAPT = 1
    }

    /// <summary>
    /// This will be built up as an internal controlled vocabulary containing entries for both ADAPT classes and ISO-11783 tags. 
    /// These objects will be used by reference.
    /// </summary>
    public class ModelScope
    {
        /// <summary>
        /// The class constructor. </summary>
        public ModelScope()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
        }

        /// <summary>
        /// Id property. </summary>
        /// <value>
        /// This will give us a locally-scoped, simplified identifier to use in referencing the object within ContextItemDefinition. This value is required.</value>
        public CompoundIdentifier Id { get; private set; }

        /// <summary>
        /// Code property. </summary>
        /// <value>
        /// This is a "friendly code" that should make querying easier. This value is required.</value>
        public string Code { get; set; }

        /// <summary>
        /// Description property. </summary>
        /// <value>
        /// This is a "friendly name" that should make selection from a pick list easier. This value is required.</value>
        public string Description { get; set; }

        /// <summary>
        /// ModelScopeType property. </summary>
        /// <value>
        /// Enumeration selection describing the which model this scope comes from. This value is required.</value>
        public ModelScopeTypeEnum ModelScopeType { get; set; }
    }
}