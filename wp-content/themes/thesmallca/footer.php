<?php
/**
 * The template for displaying the footer
 *
 * Contains the closing of the #content div and all content after.
 *
 * @link https://developer.wordpress.org/themes/basics/template-files/#template-partials
 *
 * @package thesmallca
 */

?>

<footer>
    <div class="container">
        <div class="footer-top">
            <div class="row">
                <div class="col-md-7">
                    <div class="info-fter">
                        <ul>
                            <li>
                                <label>address</label>
                                <p><?= nl2br(get_field('address', 'option')); ?></p>
                            </li>
                            <li>
                                <label>phone</label>
                                <p><?php the_field('phone_1', 'option'); ?></p>
                            </li>
                            
                        </ul>
                    </div>
                </div>
                <div class="col-md-5">
                    <div class="avr"><img src="<?php the_field('banner', 'option'); ?>" class="img-fluid" alt=""></div>
                </div>
            </div>
        </div>
        <div class="footer-center">
            <div class="get-touch">
                <h2><?php the_field('question', 'option'); ?></h2><a href="mailto:<?php the_field('email', 'option'); ?>"><?php the_field('email', 'option'); ?></a>
            </div>
            <div class="social">
                <ul>
                	<?php while ( has_sub_field('danh_sach', 'option') ) : ?>
	                <li><a href="<?php the_sub_field('link'); ?>"><img src="<?php the_sub_field('icon'); ?>" class="img-fluid" alt=""></a></li>
					<?php endwhile; ?>
                </ul>
            </div>
        </div>
        <div class="footer-bottom">
            <div class="desc">
                <?= nl2br(get_field('slogan', 'option')); ?>
            </div>
        </div>
    </div>
</footer>
<script type="text/javascript" src="https://cdn.jsdelivr.net/gh/studio-freight/lenis@latest/bundled/lenis.js"></script>
<script type="text/javascript" src="https://unpkg.co/gsap@3/dist/gsap.min.js"></script>
<script type="text/javascript" src="https://unpkg.com/gsap@3/dist/ScrollTrigger.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/ScrollMagic/2.0.5/ScrollMagic.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/ScrollMagic/2.0.5/plugins/animation.gsap.js"></script>
<script type="text/javascript" src="https://unpkg.com/aos@2.3.0/dist/aos.js"></script>
<script type="text/javascript" src="<?php bloginfo( 'stylesheet_directory' ); ?>/assets/js/private.js"></script>

<?php wp_footer(); ?>

</body>
</html>
