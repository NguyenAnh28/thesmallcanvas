<?php
/**
 * The header for our theme
 *
 * This is the template that displays all of the <head> section and everything up until <div id="content">
 *
 * @link https://developer.wordpress.org/themes/basics/template-files/#template-partials
 *
 * @package thesmallca
 */

?>
<!doctype html>
<html <?php language_attributes(); ?>>
<head>
	<meta charset="<?php bloginfo( 'charset' ); ?>">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="profile" href="https://gmpg.org/xfn/11">
	<link rel="stylesheet" type="text/css" title="" href="https://unpkg.com/aos@2.3.0/dist/aos.css">
	<link rel="stylesheet" type="text/css" title="" href="<?php bloginfo( 'stylesheet_directory' ); ?>/assets/css/style.css">
    <script type="text/javascript" src="<?php bloginfo( 'stylesheet_directory' ); ?>/assets/js/lib/jquery.min.js"></script>
    <link rel="icon" href="<?php the_field('favicon','option'); ?>" type="image/x-icon" />
	<?php wp_head(); ?>
</head>

<body <?php body_class(); ?>>
<?php wp_body_open(); ?>
	<header>
	    <div class="header-main">
	        <div class="container">
	            <div class="content-header">
	                <div class="logo">
	                    <a href="/">
	                        <svg width="48" height="48" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg">
	                            <path d="M37.2986 9.18006C33.7786 5.98006 29.1186 4.06006 23.9986 4.06006C12.9986 4.06006 4.05859 13.0001 4.05859 24.0001C4.05859 35.0001 12.9986 43.9401 23.9986 43.9401C29.1186 43.9401 33.7786 42.0201 37.2986 38.8201C41.3786 35.2001 43.9386 29.8801 43.9386 24.0001C43.9386 18.1201 41.3786 12.8001 37.2986 9.18006ZM23.9386 32.7801C23.8986 36.0801 21.4386 36.8801 19.1386 35.9601C14.3986 34.0601 11.0586 29.4201 11.0586 24.0001C11.0586 18.5801 14.3986 13.9401 19.1386 12.0201C21.4386 11.1001 23.8986 11.9201 23.9386 15.2001V32.7801Z" fill="#181818"/>
	                        </svg>
	                    </a>
	                </div>
	                <div class="btn-menu">
	                    <a href="javascript:void(0)" class="clc-menu">MENU</a>
	                </div>
	            </div>
	        </div>
	    </div>
	    <div class="nav-menu">
	        <div class="container">
	            <div class="content-nav">
	                <div class="content-header">
	                    <div class="logo">
	                        <a href="/">
	                            <svg width="48" height="48" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg">
	                                <path d="M37.3025 9.17957C33.7825 5.97957 29.1225 4.05957 24.0025 4.05957C13.0025 4.05957 4.0625 12.9996 4.0625 23.9996C4.0625 34.9996 13.0025 43.9396 24.0025 43.9396C29.1225 43.9396 33.7825 42.0196 37.3025 38.8196C41.3825 35.1996 43.9425 29.8796 43.9425 23.9996C43.9425 18.1196 41.3825 12.7996 37.3025 9.17957ZM23.9425 32.7796C23.9025 36.0796 21.4425 36.8796 19.1425 35.9596C14.4025 34.0596 11.0625 29.4196 11.0625 23.9996C11.0625 18.5796 14.4025 13.9396 19.1425 12.0196C21.4425 11.0996 23.9025 11.9196 23.9425 15.1996V32.7796Z" fill="#FFFCE1"/>
	                            </svg>
	                        </a>
	                    </div>
	                    <div class="btn-menu">
	                        <a href="javascript:void(0)" class="clc-menu">CLOSE</a>
	                    </div>
	                </div>
	                <div class="h-menu">
	                    <?php
						wp_nav_menu(
							array(
								'theme_location' => 'menu-1',
								'menu_id'        => 'primary-menu',
							)
						);
						?>
	                </div>
	                <div class="social">
	                    <ul>
	                        <?php while ( has_sub_field('danh_sach', 'option') ) : ?>
			                <li><a href="<?php the_sub_field('link'); ?>"><img src="<?php the_sub_field('icon'); ?>" class="img-fluid" alt=""></a></li>
							<?php endwhile; ?>
	                    </ul>
	                </div>
	            </div>
	        </div>
	    </div>
	</header>