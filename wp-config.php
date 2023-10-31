<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the web site, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * Database settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/documentation/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** Database settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'milktea' );

/** Database username */
define( 'DB_USER', 'root' );

/** Database password */
define( 'DB_PASSWORD', '' );

/** Database hostname */
define( 'DB_HOST', 'localhost' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         'CsxTk`<>l<U]Wa(*By_A}nA|)xG-RV#=fYf/00`0k_=R)v(gJp/KtvS^MOo/$@r[' );
define( 'SECURE_AUTH_KEY',  'uI1)5q^Os6V>}+][Q&R*p63uVp^F(#TAHg}{&W#56o>G80!g!pCAq8Di}Xg ]DWP' );
define( 'LOGGED_IN_KEY',    'a_<0ya D00fI(W&fse=^=biJkOCM5CE(I`^D]{lEv;IG @)qx-Kt&*LB()D/J*%J' );
define( 'NONCE_KEY',        'e{q/z|~KolX.Qaa3*y}h`JqIi42&/7r5J=/ M1^udMz&_ ZlyZX#Kt7,Ju{xcP.o' );
define( 'AUTH_SALT',        '-dH=}4~AF4v{8%)pCug5&a8zLL_B^>+:PLC%eybt@WSuM{,Dd>s#Z_4;OXx-w1d?' );
define( 'SECURE_AUTH_SALT', 'jiRame=`Qm~C}uWz40c{(fi+pFwbgpxd{?xh}! Hy6Br3EL<g7 ,dAG7.:,D`|#$' );
define( 'LOGGED_IN_SALT',   '|?XHg=,5v=5J{s;# ^L|CHu|c7PVn< PAy4:?.4$jxk;{pgW;G.Dcj.u-V-x*JsJ' );
define( 'NONCE_SALT',       ';LRx8f`:fAqTBW/y^)AJ`Ud7{&1v;!/XkTlt4h=jP2aN?+on}[zmS3]0u?fW{#[0' );

/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/documentation/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
