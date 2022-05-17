/* *********************************************************************
 * This Original Work is copyright of 51 Degrees Mobile Experts Limited.
 * Copyright 2022 51 Degrees Mobile Experts Limited, Davidson House,
 * Forbury Square, Reading, Berkshire, United Kingdom RG1 3EU.
 *
 * This Original Work is licensed under the European Union Public Licence
 * (EUPL) v.1.2 and is subject to its terms as set out below.
 *
 * If a copy of the EUPL was not distributed with this file, You can obtain
 * one at https://opensource.org/licenses/EUPL-1.2.
 *
 * The 'Compatible Licences' set out in the Appendix to the EUPL (as may be
 * amended by the European Commission) shall be deemed incompatible for
 * the purposes of the Work and the provisions of the compatibility
 * clause in Article 5 of the EUPL shall not apply.
 * 
 * If using the Work as, or as part of, a network application, by 
 * including the attribution notice(s) required under Article 5 of the EUPL
 * in the end user terms of the application under an appropriate heading, 
 * such notice(s) shall fulfill the requirements of that article.
 * ********************************************************************* */

using System;
using System.Collections.Generic;
using System.Text;

namespace FiftyOne.GeoLocation.Core
{
    /// <summary>
    /// This enumeration defines the reverse geocoding service providers that
    /// are supported by the engines in this package.
    /// </summary>
    public enum GeoLocationProvider
    {
        /// <summary>
        /// A FiftyOne degrees hosted solution that is powered by the
        /// <a href="https://wiki.openstreetmap.org/wiki/Nominatim">Nominatim</a> 
        /// API using data from 
        /// <a href="https://www.openstreetmap.org/">OpenStreetMap</a>.
        /// </summary>
        FiftyOneDegrees,
        /// <summary>
        /// The <a href="https://www.digitalelement.com/solutions/geomprint/">GeoMprint</a>
        /// solution from Digital Element.
        /// </summary>
        DigitalElement
    }
}
