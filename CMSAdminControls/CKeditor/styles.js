/**
 * Copyright (c) 2003-2015, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

// This file contains style definitions that can be used by CKEditor plugins.
//
// The most common use for it is the "stylescombo" plugin, which shows a combo
// in the editor toolbar, containing all styles. Other plugins instead, like
// the div plugin, use a subset of the styles on their feature.
//
// If you don't have plugins that depend on this file, you can simply ignore it.
// Otherwise it is strongly recommended to customize this file to match your
// website requirements and design properly.

/**
 * Documentation for these fields are here:
 * https://docs.kentico.com/k10/managing-website-content/configuring-the-environment-for-content-editors/configuring-the-editor/defining-styles-for-the-editor 
 */

CKEDITOR.stylesSet.add( 'default', [
	{ name: 'Paragraph',		element: 'p'  },
	{ name: 'Heading 2',		element: 'h2' },
	{ name: 'Heading 3',		element: 'h3' },
	{ name: 'Heading 4',		element: 'h4' },
	{
		name: 'Lead Paragraph',
		element: 'p',
		attributes:
		{ 
			'class': 'lead'
		}
	},
    {
        name: 'Default',
        element: 'ol',
        attributes: { 'style': 'list-style-type: decimal;' }
    },
    {
		name: 'Uppercase Alpha',
		element: 'ol',
		attributes: { 'style': 'list-style-type: upper-alpha' }
	},
	{
		name: 'Lowercase Alpha',
		element: 'ol',
		attributes: { 'style': 'list-style-type: lower-alpha' }
	},
    {
		name: 'Uppercase Roman',
		element: 'ol',
		attributes: { 'style': 'list-style-type: upper-roman' }
	},
	{
		name: 'Lowercase Roman',
		element: 'ol',
		attributes: { 'style': 'list-style-type: lower-roman' }
	}
] );

